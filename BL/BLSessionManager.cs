using BE;
using DAL;
using System;

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
      
        private static Object _lock = new object();

        public static BLSessionManager GetInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_session == null)
                        _session = new BLSessionManager();
                }

                return _session;
            }
        }
        public static void login(Usuario usu)
        {
            var session = GetInstance;
            if (session.usuario == null)
            {
                session.usuario = usu;
            }
            else
            {
                throw new Exception("Ya hay una sesión iniciada");
            }
        }

        public static void logaut()
        {
            var session = GetInstance;
            if (session.usuario != null)
            {
                session.usuario = null;
            }
            else
            {
                throw new Exception("No hay sesión iniciada");
            }
        }
    }
}
