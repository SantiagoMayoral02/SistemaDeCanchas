
using BE;
using DAL;
using System.Collections.Generic;
using System.Data;

namespace BL
{
    public class BLGestorIdioma
    {
        GestorIdiomaDAL gestorIdiomaDAL = new GestorIdiomaDAL();
        public Dictionary<string, string> ObtenerTraducciones(Idioma idioma)
        {
            return gestorIdiomaDAL.ObtenerTraducciones(idioma);
        }
        public List<Idioma> ObtenerIdiomas()
        {
            return gestorIdiomaDAL.ObtenerIdiomas();
        }
        public bool InsertarNuevoIdioma(Idioma idioma)
        {
            return gestorIdiomaDAL.InsertarIdioma(idioma);
        }

        public bool InsertarEtiqueta(Etiqueta etiqueta)
        {
            return gestorIdiomaDAL.InsertarEtiqueta(etiqueta);
        }

        public void InsertarTraduccion(int idIdioma, string nombreEtiqueta, string texto)
        {
            gestorIdiomaDAL.InsertarTraduccion(idIdioma,nombreEtiqueta,texto);
        }

        public List<Etiqueta> ObtenerEtiquetas()
        {
            return gestorIdiomaDAL.ObtenerEtiquetas();
        }
        public List<(string Etiqueta, string Idioma, string Traduccion)> ObtenerEtiquetasConTraducciones()
        {
            return gestorIdiomaDAL.ObtenerEtiquetasConTraducciones();
        }

        public List<string> ObtenerEtiquetasFaltantes(List<string> etiquetasDelSistema)
        {
            return gestorIdiomaDAL.ObtenerEtiquetasFaltantes(etiquetasDelSistema);
        }
    }
}
