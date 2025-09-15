using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    public static class EtiquetaHelper
    {
        private static HashSet<string> _etiquetas = new HashSet<string>();

        public static void Registrar(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                _etiquetas.Add(nombre);
            }
        }

        public static List<string> ObtenerEtiquetasRegistradas()
        {
            return _etiquetas.ToList();
        }
    
        private static void RegistrarEtiquetasDeControles(Control control)
        {
            if (control.Tag != null)
            {
                Registrar(control.Tag.ToString());
            }

            foreach (Control child in control.Controls)
            {
                RegistrarEtiquetasDeControles(child);
            }
        }
        public static void RegistrarEtiquetasDeTodosLosFormularios()
        {
            var tiposFormularios = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Form)) && !t.IsAbstract);

            foreach (var tipo in tiposFormularios)
            {
                try
                {
                    var ctor = tipo.GetConstructor(Type.EmptyTypes);
                    if (ctor != null)
                    {
                        using (var form = (Form)ctor.Invoke(null))
                        {
                            RegistrarControlesRecursivos(form);
                        }
                    }
                }
                catch { }
            }
        }
        private static void RegistrarControlesRecursivos(Control control)
        {
            if (control.Tag != null)
            {
                Registrar(control.Tag.ToString());
            }

            foreach (Control child in control.Controls)
            {
                RegistrarControlesRecursivos(child);
            }
        }
    }
}

