using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface ISujetoIdioma
    {
        void Agregar(IObserverIdioma observer);
        void Quitar(IObserverIdioma observer);
        void Notificar();
    }
}
