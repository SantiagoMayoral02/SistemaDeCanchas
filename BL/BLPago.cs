using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLPago
    {
        private PagoDAL dal = new PagoDAL();

        public void RegistrarPago(Pago pago)
        {
            dal.InsertarPago(pago);
        }
    }
}
