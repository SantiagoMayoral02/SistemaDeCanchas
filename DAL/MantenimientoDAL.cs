using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MantenimientoDAL
    {
        DAO dao = new DAO();
        public void InsertarMantenimiento(Mantenimiento mantenimiento)
        {
            var parametros = new Dictionary<string, object>
            {
                { "@CanchaId", mantenimiento.CanchaId },
                { "@FechaInicio", mantenimiento.FechaInicio },
                { "@FechaFin", mantenimiento.FechaFin },
                { "@Motivo", mantenimiento.Motivo }
            };

            dao.ExecuteNonQuery("InsertarMantenimiento", parametros);
        }
    }
}
