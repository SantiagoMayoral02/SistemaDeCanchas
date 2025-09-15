using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLReserva
    {
        ReservaDAL reservaDAL = new ReservaDAL();
        public void InsertarReserva(Reserva reserva)
        {
            reservaDAL.InsertarReserva(reserva);
        }
        public bool VerDisponibilidad(int idCancha, DateTime fecha, TimeSpan horaInicio, int duracionHoras)
        {
            return reservaDAL.VerDisponibilidad(idCancha, fecha, horaInicio, duracionHoras);
        }
        public DataRow ObtenerComprobanteReserva(int idReserva)
        {
            return reservaDAL.ObtenerComprobanteReserva(idReserva);
        }
        public void CancelarReserva(int idReserva)
        {
             reservaDAL.CancelarReserva(idReserva);
        }
        public List<Reserva> ObtenerTodasLasReservas()
        {
            return reservaDAL.ObtenerTodasLasReservas();
        }
        public List<Reserva> ObtenerReservasPendientes()
        {
            return reservaDAL.ObtenerReservasPendientes();
        }
    }
}
