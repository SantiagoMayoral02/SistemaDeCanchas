using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PagoDAL
    {
        DAO dao = new DAO();
        public void InsertarPago(Pago pago)
        {
            var parametros = new Dictionary<string, object>
            {
                { "@ReservaId", pago.ReservaId },
                { "@FechaPago", pago.FechaPago },
                { "@Monto", pago.Monto },
                { "@MedioPago", pago.MetodoPago }
                };

            dao.ExecuteNonQuery("InsertarPago", parametros);
        }
    }
}
