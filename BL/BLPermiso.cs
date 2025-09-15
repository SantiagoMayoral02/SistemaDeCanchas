using BE;
using DAL;  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLPermiso
    {
        PermisoDAL permisoDal;
        public BLPermiso()
        {
            permisoDal = new PermisoDAL();
        }
        public bool Existe(Componente c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }
        public Array GetAllPermission()
        {
            return permisoDal.GetAllPermission();
        }


        public Componente GuardarComponente(Componente p, bool esfamilia)
        {
            return permisoDal.GuardarComponente(p, esfamilia);
        }


        public void GuardarFamilia(Familia c)
        {
            permisoDal.GuardarFamilia(c);
        }

        public IList<Patente> GetAllPatentes()
        {
            return permisoDal.GetAllPatentes();
        }

        public IList<Familia> GetAllFamilias()
        {
            return permisoDal.GetAllFamilias();
        }

        public IList<Componente> GetAll(string familia)
        {
            return permisoDal.GetAll(familia);

        }

        public void FillUserComponents(Usuario u)
        {
            permisoDal.FillUserComponents(u);

        }

        public void FillFamilyComponents(Familia familia)
        {
            permisoDal.FillFamilyComponents(familia);
        }
        public void GuardarPermisoUsuario(Usuario u)
        {
            permisoDal.GuardarPermisosUsuario(u);
        }
    }
}
