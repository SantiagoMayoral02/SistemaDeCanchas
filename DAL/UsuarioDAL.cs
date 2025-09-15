using BE;
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
        DAO dAO = new DAO();
        PermisoDAL permisoDAL = new PermisoDAL();   
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
        public Usuario ValidarUsuario(string nom)
        {
            try
            {
                string commandText = "BuscarUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", nom }
                };
                DataSet ds = dAO.ExecuteDataSet(commandText, parametros);

                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];

                    Usuario usu = new Usuario();
                    usu.Nombre = row["Nombre"].ToString();
                    usu.Contrasena = row["Contrasena"].ToString();
                    usu.Id = Convert.ToInt32(row["id_usuario"]);
                    usu.IntentosFallidos = Convert.ToInt32(row["IntentosFallidos"]);
                    bool bloqueado = Convert.ToBoolean(row["Bloqueado"]);
                    if (bloqueado)
                    {
                        MessageBox.Show("Usuario bloqueado por intentos fallidos. Por favor contacte al administrador");
                        return null;
                    }
                    permisoDAL.FillUserComponents(usu);
                    return usu;
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
        public void ActualizarIntentosFallidos(int idUsuario, int intentos)
        {
            try
            {
                string commandText = "ActualizarIntentosFallidos";
                var parametros = new Dictionary<string, object>
                {
                    { "@id", idUsuario },
                    { "@intentos", intentos }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void BloquearUsuario(int idUsuario)
        {
            try
            {
                string commandText = "BloqueaUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@id", idUsuario }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int CambiarContraseña(int id, string contra)
        {
            try
            {
                string commandText = "CambiarContrasenaUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@id", id },
                    { "@nuevaContraseña", contra }
                };
                return dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int CambiarNombreUsuario(int id, string nombre)
        {
            try
            {
                string commandText = "CambiarNombreUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@id_usuario", id },
                    { "@nuevoUsuario", nombre }
                };
                return dAO.ExecuteNonQuery(commandText, parametros);
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
                int result = dAO.ExecuteNonQuery(commandText, parametros);
                return result;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public List<Usuario> ObtenerUsuarios()
        {
            try
            {
                List<Usuario> listUsuarios = new List<Usuario>();
                string commandText = "ObtenerUsuarios";
                DataSet ds = dAO.ExecuteDataSet(commandText);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Usuario usu = new Usuario();
                        usu.Nombre = row["Nombre"].ToString();
                        usu.Id = Convert.ToInt32(row["id_usuario"]);
                        usu.Bloqueado = Convert.ToBoolean(row["Bloqueado"]);
                        listUsuarios.Add(usu);
                    }
                }
                return listUsuarios;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DesbloquearUsuario(int idUsuario)
        {
            try
            {
                string commandText = "DesbloquearUsuario";
                var parametros = new Dictionary<string, object>
                {
                    { "@id", idUsuario }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
