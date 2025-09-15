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
    public class ReservaDAL
    {
        DAO dAO = new DAO();
        public void InsertarReserva(Reserva reserva)
        {
            try
            {
                string commandText = "InsertarReserva"; 
                var parametros = new Dictionary<string, object>
                {
                    { "@IdCliente", reserva.IdCliente },
                    { "@IdCancha", reserva.IdCancha },
                    { "@Fecha", reserva.Fecha },
                    { "@HoraInicio", reserva.HoraInicio },
                    { "@DuracionHoras", reserva.DuracionHoras },
                    { "@Total", reserva.Total },
                    { "@Estado", reserva.Estado },
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool VerDisponibilidad(int idCancha, DateTime fecha, TimeSpan horaInicio, int duracionHoras)
        {
            try
            {
                string commandText = "VerDisponibilidadCancha"; 
                var parametros = new Dictionary<string, object>
                {
                    { "@IdCancha", idCancha },
                    { "@Fecha", fecha.Date },
                    { "@HoraInicio", horaInicio },
                    { "@DuracionHoras", duracionHoras }
                };
                var ds = dAO.ExecuteDataSet(commandText, parametros);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    int cantidad = Convert.ToInt32(ds.Tables[0].Rows[0]["ReservasEnConflicto"]);
                    return cantidad == 0;
                }

                return false;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public DataRow ObtenerComprobanteReserva(int idReserva)
        {
            try
            {
                string commandText = "GetComprobanteReserva";
                var parametros = new Dictionary<string, object>
                {
                    { "@IdReserva", idReserva }
                };
                var ds = dAO.ExecuteDataSet(commandText, parametros);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0];
                }
                return null;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void CancelarReserva(int idReserva)
        {
            try
            {
                string commandText = "CancelarReserva";
                var parametros = new Dictionary<string, object>
                {
                    { "@IdReserva", idReserva }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public List<Reserva> ObtenerTodasLasReservas()
        {
            var reservas = new List<Reserva>();
            var ds = dAO.ExecuteDataSet("ObtenerTodasLasReservas", null);

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    reservas.Add(new Reserva
                    {
                        IdReserva = Convert.ToInt32(row["IdReserva"]),
                        NombreCliente = row["Cliente"].ToString(),
                        NombreCancha = row["Cancha"].ToString(),
                        Fecha = Convert.ToDateTime(row["Fecha"]),
                        HoraInicio = TimeSpan.Parse(row["HoraInicio"].ToString()),
                        DuracionHoras = Convert.ToInt32(row["DuracionHoras"]),
                        Total = Convert.ToDecimal(row["Total"]),
                        Estado = row["Estado"].ToString()
                    });
                }
            }

            return reservas;
        }
        public List<Reserva> ObtenerReservasPendientes()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                var ds = dAO.ExecuteDataSet("ObtenerReservasPendientes", null);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    reservas.Add(new Reserva
                    {
                        IdReserva = Convert.ToInt32(row["IdReserva"]),
                        NombreCliente = row["ClienteNombre"].ToString(),
                        Fecha = Convert.ToDateTime(row["Fecha"]),
                        HoraInicio = TimeSpan.Parse(row["HoraInicio"].ToString()),
                        Estado = row["Estado"].ToString(),
                        NombreCancha = row["Cancha"].ToString(),
                        Total = Convert.ToDecimal(row["Total"])
                    });
                }

                return reservas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al recuperar reservas pendientes", ex);
            }
        }
    }
}
