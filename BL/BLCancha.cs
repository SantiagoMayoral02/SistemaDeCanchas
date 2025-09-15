using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CanchaBL
    {
        private readonly CanchaDAL canchaDAL = new CanchaDAL();

        public List<Cancha> ObtenerCanchasPorTipo(string tipo)
        {
            return canchaDAL.ObtenerCanchasPorTipo(tipo);
        }

        public Cancha ObtenerCanchaPorId(int id)
        {
            return canchaDAL.ObtenerCanchaPorId(id);
        }
        public List<TipoCancha> ObtenerTodosLosTiposDeCancha()
        {
            return canchaDAL.ObtenerTodosLosTiposDeCancha();
        }
        public List<Cancha> ObtenerTodasLasCanchas()
        {
            return canchaDAL.ObtenerTodasLasCanchas();
        }
        public void InsertarNuevoTipoCancha(TipoCancha tipoCancha)
        {
            canchaDAL.InsertarNuevoTipoCancha(tipoCancha);
        }
        public void InsertarNuevaCancha(Cancha cancha)
        {
            canchaDAL.InsertarNuevaCancha(cancha);
        }
        public void ActualizarNombreCancha(int idCancha, string nombre)
        {
            canchaDAL.ActualizarNombreCancha(idCancha, nombre);
        }
        public void ActualizarDescripcionCancha(int idCancha, string descripcion)
        {
            canchaDAL.ActualizarDescripcionCancha(idCancha, descripcion);
        }
        public void ActualizarPrecioCancha(int idCancha, decimal precioHora)
        {
            canchaDAL.ActualizarPrecioCancha(idCancha, precioHora);
        }
    }
}
