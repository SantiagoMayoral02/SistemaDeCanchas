using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class PermisoDAL
    {
        DAO dAO = new DAO();
        public Array GetAllPermission()
        {
            return Enum.GetValues(typeof(TipoPermiso));
        }
        public Componente GuardarComponente(Componente p, bool esfamilia)
        {
            try
            {
                string commandText = "GuardarComponente";
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", p.Nombre }
                };
                if (esfamilia)
                    parametros.Add("@permiso", DBNull.Value);
                else
                    parametros.Add("@permiso", p.Permiso.ToString());


                var id = dAO.ExecuteScalar(commandText, parametros);
                p.Id = (int)id;
                return p;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void GuardarFamilia(Familia c)
        {

            try
            {
                string commandText = "GuardarFamilia";

                var hijosTable = new DataTable();
                hijosTable.Columns.Add("id", typeof(int));
                foreach (var hijo in c.Hijos)
                {
                    hijosTable.Rows.Add(hijo.Id);
                }

                var parametros = new Dictionary<string, object>
                {
                    { "@id_familia", c.Id },
                    { "@hijos_ids", hijosTable }  // ¡IMPORTANTE! El DataTable debe tener misma estructura que el tipo IdList
                };

                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        public IList<Patente> GetAllPatentes()
        {
            List<Patente> lista = new List<Patente>();

            try
            {
                var ds = dAO.ExecuteDataSet("GetAllPatentes", null);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Patente patente = new Patente
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nombre = row["nombre"].ToString(),
                            Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), row["permiso"].ToString())
                        };

                        lista.Add(patente);
                    }
                }
                return lista;
            }
            catch (Exception e )
            {
                throw e;
            }
        }
        public IList<Familia> GetAllFamilias()
        {
            List<Familia> lista = new List<Familia>();

            try
            {
                var ds = dAO.ExecuteDataSet("GetAllFamilias", null);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Familia familia = new Familia
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nombre = row["nombre"].ToString()
                        };

                        lista.Add(familia);
                    }
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public IList<Componente> GetAll(string familia)
        {
            List<Componente> lista = new List<Componente>();

            try
            {
                int? familiaId = null;
                if (!string.IsNullOrEmpty(familia) && int.TryParse(familia.Trim('='), out int parsedId))
                {
                    familiaId = parsedId;
                }

                var parametros = new Dictionary<string, object>
                {                   
                    { "@familiaId", familiaId != null ? (object)familiaId : DBNull.Value }
                };

                var ds = dAO.ExecuteDataSet("GetAllComponentes", parametros);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        int id = Convert.ToInt32(row["id"]);
                        string nombre = row["nombre"].ToString();
                        string permisoStr = row["permiso"] != DBNull.Value ? row["permiso"].ToString() : null;
                        int? idPadre = row["id_permiso_padre"] != DBNull.Value ? Convert.ToInt32(row["id_permiso_padre"]) : (int?)null;

                        Componente componente;
                        if (string.IsNullOrEmpty(permisoStr))
                        {
                            componente = new Familia();
                        }
                        else
                        {
                            componente = new Patente
                            {
                                Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permisoStr)
                            };
                        }

                        componente.Id = id;
                        componente.Nombre = nombre;

                        var padre = GetComponent(idPadre, lista);
                        if (padre == null)
                            lista.Add(componente);
                        else
                            padre.AgregarHijo(componente);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }
        private Componente GetComponent(int? id, IList<Componente> lista)
        {
            if (id == null) return null;

            foreach (var componente in lista)
            {
                if (componente.Id == id)
                    return componente;

                var hijoEncontrado = GetComponent(id, componente.Hijos);
                if (hijoEncontrado != null)
                    return hijoEncontrado;
            }

            return null;
        }
        public void FillUserComponents(Usuario u)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@usuarioId", u.Id }
                };
                var ds = dAO.ExecuteDataSet("ObtenerPermisosUsuario", parametros);

                u.Permisos.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string nombre = row["nombre"].ToString();
                    string permisoStr = row["permiso"] != DBNull.Value ? row["permiso"].ToString() : null;

                    Componente c;

                    if (!string.IsNullOrEmpty(permisoStr))
                    {
                        c = new Patente
                        {
                            Id = id,
                            Nombre = nombre,
                            Permiso = (TipoPermiso)Enum.Parse(typeof(TipoPermiso), permisoStr)
                        };
                    }
                    else
                    {
                        c = new Familia
                        {
                            Id = id,
                            Nombre = nombre
                        };

                        FillFamilyComponents((Familia)c);
                    }

                    u.Permisos.Add(c);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los permisos del usuario", ex);
            }
        }
        public void FillFamilyComponents(Familia familia)
        {
            familia.VaciarHijos();
            foreach (var hijo in GetAll("=" + familia.Id))
            {
                familia.AgregarHijo(hijo);
            }
        }
        //public void GuardarPermisoUsuario(Usuario u)
        //{
        //    try
        //    {
        //        var parametrosEliminar = new Dictionary<string, object>
        //        {
        //            { "@id_usuario", u.Id }
        //        };
        //        dAO.ExecuteNonQuery("EliminarPermisosUsuario", parametrosEliminar);

        //        foreach (var permiso in u.Permisos)
        //        {
        //            GuardarPermisoRecursivo(u.Id, permiso);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error al guardar permisos del usuario en la base de datos.", ex);
        //    }
        //}

        //private void GuardarPermisoRecursivo(int idUsuario, Componente permiso)
        //{
        //    // Si es una patente, se guarda
        //    if (permiso is Patente)
        //    {
        //        var parametrosInsertar = new Dictionary<string, object>
        //        {
        //            { "@id_usuario", idUsuario },
        //            { "@id_permiso", permiso.Id }
        //        };

        //        dAO.ExecuteNonQuery("GuardarUsuarioPermiso", parametrosInsertar);
        //    }
        //    else // Es una familia, recorrer hijos
        //    {
        //        foreach (var hijo in permiso.Hijos)
        //        {
        //            GuardarPermisoRecursivo(idUsuario, hijo);
        //        }
        //    }
        //}
        public void GuardarPermisosUsuario(Usuario u)
        {
            try
            {
                var parametrosEliminar = new Dictionary<string, object>
                {
                    { "@id_usuario", u.Id }
                };
                dAO.ExecuteNonQuery("EliminarPermisosUsuario", parametrosEliminar);

                foreach (var permiso in u.Permisos)
                {
                    var parametrosInsertar = new Dictionary<string, object>
                    {
                        { "@id_usuario", u.Id },
                        { "@id_permiso", permiso.Id }
                    };
                    dAO.ExecuteNonQuery("GuardarUsuarioPermiso", parametrosInsertar);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar los permisos del usuario.", ex);
            }
        }
    }
}
