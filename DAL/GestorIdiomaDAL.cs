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
    public class GestorIdiomaDAL
    {
        DAO _dao = new DAO();
        public Dictionary<string, string> ObtenerTraducciones(Idioma idioma)
        {
            var diccionario = new Dictionary<string, string>();
            var parametros = new Dictionary<string, object>
            {
                { "@id_idioma", idioma.Id }
            };  

            var ds = _dao.ExecuteDataSet("ObtenerTraducciones",parametros);  

            if (ds.Tables.Count > 0)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string clave = row["Nombre"].ToString();
                    string texto = row["Texto"].ToString();
                    diccionario[clave] = texto;
                }
            }

            return diccionario;
        }
        public List<Idioma> ObtenerIdiomas()
        {
            var lista = new List<Idioma>();

            try
            {
                var ds = _dao.ExecuteDataSet("ObtenerIdiomas", null);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        var idioma = new Idioma
                        {
                            Id = Convert.ToInt32(row["Id_idioma"]),
                            Nombre = row["Nombre"].ToString()
                        };
                        lista.Add(idioma);
                    }
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los idiomas.", ex);
            }
        }
        public bool InsertarIdioma(Idioma idioma)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    {"@Nombre", idioma.Nombre}
                };
                return _dao.ExecuteNonQuery("InsertarIdioma", parametros) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar idioma", ex);
            }
        }

        public bool InsertarEtiqueta(Etiqueta etiqueta)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    {"@Nombre", etiqueta.Nombre}
                };
                return _dao.ExecuteNonQuery("InsertarEtiqueta", parametros) > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar etiqueta", ex);
            }
        }

        public void InsertarTraduccion(int idIdioma, string nombreEtiqueta, string texto)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@id_idioma", idIdioma },
                    { "@nombre_etiqueta", nombreEtiqueta },
                    { "@texto", texto }
                };

                _dao.ExecuteNonQuery("InsertarTraduccion", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la traducción.", ex);
            }
        }

        public List<Etiqueta> ObtenerEtiquetas()
        {
            try
            {
                var etiquetas = new List<Etiqueta>();
                var ds = _dao.ExecuteDataSet("ObtenerEtiquetas", null);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    etiquetas.Add(new Etiqueta
                    {
                        Id = Convert.ToInt32(row["Id_etiqueta"]),
                        Nombre = row["Nombre"].ToString()
                    });
                }
                return etiquetas;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener etiquetas", ex);
            }
        }
        public List<string> ObtenerEtiquetasFaltantes(List<string> etiquetasDelSistema)
        {
            List<string> etiquetasFaltantes = new List<string>();

            foreach (string etiqueta in etiquetasDelSistema)
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@Nombre", etiqueta }
                };

                using (var reader = _dao.ExecuteReader("ExisteEtiqueta", parametros))
                {   
                    if (reader.Read())
                    {
                        bool existe = Convert.ToBoolean(reader["Existe"]);
                        if (!existe)
                        {
                            etiquetasFaltantes.Add(etiqueta);
                        }
                    }
                }
            }

            return etiquetasFaltantes;
        }
        public List<(string Etiqueta, string Idioma, string Traduccion)> ObtenerEtiquetasConTraducciones()
        {
            var lista = new List<(string Etiqueta, string Idioma, string Traduccion)>();

            try
            {
                var ds = _dao.ExecuteDataSet("ObtenerEtiquetasConTraducciones", null);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        string etiqueta = row["NombreEtiqueta"].ToString();
                        string idioma = row["NombreIdioma"].ToString();
                        string traduccion = row["Texto"].ToString();

                        lista.Add((etiqueta, idioma, traduccion));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener etiquetas con traducciones", ex);
            }

            return lista;
        }
    }
}

