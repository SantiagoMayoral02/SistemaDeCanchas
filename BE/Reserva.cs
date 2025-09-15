using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public int IdCliente { get; set; }
        public int IdCancha { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public int DuracionHoras { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; } // Ej: "Confirmada", "Pendiente", "Cancelada"
        public string NombreCancha { get; set; }
        public string NombreCliente { get; set; }
    }
}
