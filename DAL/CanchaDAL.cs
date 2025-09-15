using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class CanchaDAL
    {
        DAO dAO = new DAO();
        public List<Cancha> ObtenerCanchasPorTipo(string tipo)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@tipo", tipo }
                };

                var ds = dAO.ExecuteDataSet("GetCanchasPorTipo", parametros);
                var lista = new List<Cancha>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    TipoCancha tipoCancha = new TipoCancha
                    {
                        IdTipoCancha = Convert.ToInt32(row["IdTipoCancha"]),
                        Nombre = row["Tipo"].ToString()
                    };
                    lista.Add(new Cancha(tipoCancha)
                    {
                        IdCancha = Convert.ToInt32(row["IdCancha"]),
                        Nombre = row["Nombre"].ToString(),
                        Descripcion = row["Descripcion"].ToString(),
                        PrecioHora = Convert.ToDecimal(row["PrecioHora"]),
                    });
                }
                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Cancha ObtenerCanchaPorId(int id)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@id", id }
                };
                var ds = dAO.ExecuteDataSet("GetCanchaPorId", parametros);
                var row = ds.Tables[0].Rows[0];

                TipoCancha tipoCancha = new TipoCancha
                {
                    IdTipoCancha = Convert.ToInt32(row["IdTipoCancha"]),
                    Nombre = row["NombreTipo"].ToString()
                };
                return new Cancha(tipoCancha)
                {
                    IdCancha = Convert.ToInt32(row["IdCancha"]),
                    Nombre = row["Nombre"].ToString(),
                    Descripcion = row["Descripcion"].ToString(),
                    PrecioHora = Convert.ToDecimal(row["PrecioHora"])
                };
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<TipoCancha> ObtenerTodosLosTiposDeCancha()
        {
            List<TipoCancha> tipos = new List<TipoCancha>();

            try
            {
                string commandText = "GetTiposDeCancha";
                var ds = dAO.ExecuteDataSet(commandText);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        TipoCancha tipoCancha = new TipoCancha
                        {
                            IdTipoCancha = Convert.ToInt32(row["IdTipoCancha"]),
                            Nombre = row["Nombre"].ToString()
                        };
                        tipos.Add(tipoCancha);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tipos de cancha.", ex);
            }

            return tipos;
        }
        public List<Cancha> ObtenerTodasLasCanchas()
        {
            var canchas = new List<Cancha>();
            try
            {
                var ds = dAO.ExecuteDataSet("ObtenerTodasLasCanchas", null);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    TipoCancha tipoCancha = new TipoCancha
                    {
                        IdTipoCancha = Convert.ToInt32(row["IdTipoCancha"]),
                        Nombre = row["TipoNombre"].ToString()
                    };

                    Cancha cancha = new Cancha(tipoCancha)
                    {
                        IdCancha = Convert.ToInt32(row["IdCancha"]),
                        Nombre = row["Nombre"].ToString(),
                        Descripcion = row["Descripcion"].ToString(),
                        PrecioHora = Convert.ToDecimal(row["PrecioHora"])
                    };
                    canchas.Add(cancha);
                }
                return canchas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener canchas", ex);
            }
        }
        public void InsertarNuevoTipoCancha(TipoCancha tipoCancha)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", tipoCancha.Nombre }
                };
                dAO.ExecuteNonQuery("InsertarTipoCancha", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar un nuevo tipo de cancha", ex);
            }
        }
        public void InsertarNuevaCancha(Cancha cancha)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@nombre", cancha.Nombre },
                    { "@descripcion", cancha.Descripcion },
                    { "@precioHora", cancha.PrecioHora },
                    { "@idTipoCancha", cancha.GetTipoCancha().IdTipoCancha }
                };
                dAO.ExecuteNonQuery("InsertarCancha", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar una nueva cancha", ex);
            }
        }
        public void ActualizarNombreCancha(int idCancha, string nombre)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@idCancha", idCancha },
                    { "@nombre", nombre }
                };
                dAO.ExecuteNonQuery("ActualizarNombreCancha", parametros);

            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar el nombre de la cancha seleccionada", ex);
            }
        }
        public void ActualizarDescripcionCancha(int idCancha, string descripcion)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@idCancha", idCancha },
                    { "@descripcion", descripcion }
                };
                dAO.ExecuteNonQuery("ActualizarDescripcionCancha", parametros);

            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar la descripción de la cancha seleccionada", ex);
            }
        }
        public void ActualizarPrecioCancha(int idCancha, decimal precioHora)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@idCancha", idCancha },
                    { "@precioHora", precioHora }
                };
                dAO.ExecuteNonQuery("ActualizarPrecioCancha", parametros);

            }
            catch (Exception ex)
            {

                throw new Exception("Error al actualizar el precio de la cancha seleccionada", ex);
            }
        }
    }
}
