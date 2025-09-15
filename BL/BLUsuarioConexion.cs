using BE;
using DAL;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class BLUsuarioConexion
    {
        UsuarioDAL UsuarioDAL = new UsuarioDAL();
        Encrypting EncryptManager = new Encrypting();
        PermisoDAL PermisoDAL = new PermisoDAL();
        public void GuardarUsuario(string nombre, string contra)
        {
            UsuarioDAL.GuardarUsuario(nombre, contra);   
        }
        public int CambiarContraseña(int id, string contra)
        {
            return UsuarioDAL.CambiarContraseña(id, contra);
        }
        public int CambiarNombreUsuario(int id, string nombre)
        {
            return UsuarioDAL.CambiarNombreUsuario(id, nombre);
        }
        public Usuario ValidarUsuario(string nom, string con)
        {
            Usuario usu = UsuarioDAL.ValidarUsuario(nom);
            if (usu != null)
            {
                if (EncryptManager.ValidarContraseña(con, usu.Contrasena))
                {
                    UsuarioDAL.ActualizarIntentosFallidos(usu.Id, 0);
                    PermisoDAL.FillUserComponents(usu);
                    return usu;
                }
                else
                {
                    int cont = usu.IntentosFallidos + 1;
                    UsuarioDAL.ActualizarIntentosFallidos(usu.Id, cont);
                    MessageBox.Show($"Contraseña incorrecta. Intento: {cont} de 3.");
                    if (cont >= 3)
                    {
                        UsuarioDAL.BloquearUsuario(usu.Id);
                        MessageBox.Show("Usuario bloqueado por exceder intentos. Comuniquese con un administrador para desbloquearlo");
                    }
                }
            }
            return null;
        }
        
        public int CrearUsuario(string nom, string con)
        {
            return UsuarioDAL.CrearUsuario(nom, con);
        }
        public List<Usuario> ObtenerUsuarios()
        {
            return UsuarioDAL.ObtenerUsuarios();
        }
        public void DesbloquearUsuario(int idUsuario)
        {
            UsuarioDAL.DesbloquearUsuario(idUsuario);
        }
    }
}
