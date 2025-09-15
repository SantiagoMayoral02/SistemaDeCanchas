using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cancha
    {
        private readonly TipoCancha Tipo;
        public Cancha(TipoCancha tipo)
        {
            Tipo = tipo;
        }
        public TipoCancha GetTipoCancha()
        {
            return Tipo;
        }
        public int IdCancha { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioHora { get; set; } 
        public string Descripcion { get; set; } 
    }
}
