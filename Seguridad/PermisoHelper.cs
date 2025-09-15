using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public static class PermisoHelper
    {
        public static bool UsuarioTienePermiso(Usuario usuario, string nombrePermiso)
        {
            if (usuario == null || string.IsNullOrEmpty(nombrePermiso))
                return false;

            foreach (var permiso in usuario.Permisos)
                {
                    if (TienePermisoRecursivo(permiso, nombrePermiso))
                        return true;
                }

            return false;
        }

        private static bool TienePermisoRecursivo(Componente componente, string nombreBuscado)
        {
            if (componente.Permiso.ToString().Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                return true;

            foreach (var hijo in componente.Hijos)
            {
                if (TienePermisoRecursivo(hijo, nombreBuscado))
                    return true;
            }

            return false;
        }
    }
}
