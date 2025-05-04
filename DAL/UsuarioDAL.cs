using BE;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class UsuarioDAL
    {
        Encrypting EncryptManager = new Encrypting();
        DAO dAO = new DAO();
        public void GuardarUsuario(string nombre, string contra)
        {
            try
            {
                string commandText = "GuardarUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", nombre },
                    { "@contraseña", contra }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        // PermisosRepository PermisosRepository = new PermisosRepository();
        public Usuario ValidarUsuario(string nom, string con)
        {
            try
            {
                string commandText = "BuscarUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", nom }
                };
                DAO dAO = new DAO();
                DataSet ds = dAO.ExecuteDataSet(commandText, parametros);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    string nombreUsuario = row["Nombre"].ToString();
                    string contrasena = row["Contrasena"].ToString();
                    int id = Convert.ToInt32(row["id_usuario"]);

                    if (nombreUsuario == nom && EncryptManager.ValidarContraseña(con, contrasena))
                    {
                        Usuario usu = new Usuario();
                        usu.Nombre = nombreUsuario;
                        usu.Contrasena = contrasena;
                        usu.Id = id;

                        // PermisosRepository.FillUserComponents(usu);
                        return usu;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                        return null;
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                    return null;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
       
        public void CambiarContraseña(int id, string contra)
        {
            try
            {
                string commandText = "CambiarContrasenaUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@id", id },
                    { "@nuevaContraseña", contra }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void CambiarUsuarioyContraseña(Usuario usu)
        {
            try
            {
                string commandText = "CambiarUsuarioyContraseña";
                var parametros = new Dictionary<string, object>
                {
                    { "@id_usuario", usu.Id },
                    { "@nuevo_nombre", usu.Nombre },
                    {"@nueva_contrasena", usu.Contrasena }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int CrearUsuario(string nom, string con)
        {
            try
            {
                string commandText = "CrearUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", nom },
                    { "@contrasena", con }
                };
                int result = dAO.ExecuteNonQuery (commandText, parametros);
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
