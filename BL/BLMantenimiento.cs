using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLMantenimiento
    {
        private MantenimientoDAL dal = new MantenimientoDAL();

        public void ProgramarMantenimiento(Mantenimiento mantenimiento)
        {
            dal.InsertarMantenimiento(mantenimiento);
        }
    }
}
