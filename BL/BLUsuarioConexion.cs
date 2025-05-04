using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLUsuarioConexion
    {
        UsuarioDAL UsuarioDAL = new UsuarioDAL();
        public void GuardarUsuario(string nombre, string contra)
        {
            UsuarioDAL.GuardarUsuario(nombre, contra);   
        }
        public void CambiarContraseña(int id, string contra)
        {
            UsuarioDAL.CambiarContraseña(id, contra);
        }
        public void CambiarUsuarioYContraseña(Usuario usu)
        {
            UsuarioDAL.CambiarUsuarioyContraseña(usu);
        }
        public Usuario ValidarUsuario(string nom, string con)
        {
            return UsuarioDAL.ValidarUsuario(nom, con); 
        }
        
        public int CrearUsuario(string nom, string con)
        {
            return UsuarioDAL.CrearUsuario(nom, con);
        }
    }
}
