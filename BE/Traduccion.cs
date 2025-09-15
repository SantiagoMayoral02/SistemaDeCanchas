using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Traduccion
    {
        public Idioma Idioma { get; set; }
        public int IdIdioma { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public int IdEtiqueta { get; set; }
        public string Texto { get; set; }
    }
}
