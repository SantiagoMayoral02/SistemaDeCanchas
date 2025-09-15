using BE;
using BL;
using BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class GestorIdioma : ISujetoIdioma
    {
        private static GestorIdioma _instancia;
        private List<IObserverIdioma> _observadores = new List<IObserverIdioma>();
        private Idioma _idiomaActual;

        public static GestorIdioma Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorIdioma();
                }
                return _instancia;
            }
        }

        public void CambiarIdioma(Idioma nuevoIdioma)
        {
            if (nuevoIdioma != null && IdiomaActual?.Id != nuevoIdioma.Id)
            {
                _idiomaActual = nuevoIdioma;
                Notificar();
            }
        }
        public void Agregar(IObserverIdioma observer)
        {
            if (!_observadores.Contains(observer))
                _observadores.Add(observer);
        }

        public void Notificar()
        {
            foreach (var o in _observadores)
            {
                o.Actualizar(_idiomaActual);
            }
        }

        public void Quitar(IObserverIdioma observer)
        {
            _observadores.Remove(observer);
        }
        public Idioma IdiomaActual => _idiomaActual;
    }
}
