using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLSessionManager
    {
        private Usuario usuario;
        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private static BLSessionManager _session;
        public static BLSessionManager GetInstance
        {
            get
            {
                return _session;
            }
        }

        public static void login(Usuario usu)
        {

            if (_session == null)
            {
                _session = new BLSessionManager();
                _session.usuario = usu;
                UsuarioDAL conexion = new UsuarioDAL();
            }
            else
            {
                throw new Exception("Sesion no iniciada");
            }
        }

        public static void logaut()
        {
            if (_session != null)
            {
                _session = null;
            }
            else
            {
                throw new Exception("Sesion no iniciada");
            }
        }
    }
}
