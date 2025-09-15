using DAL;
using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BL
{
    public class BLBitacora
    {
        BitacoraDAL BitacoraDAL = new BitacoraDAL();
        
        public void InsertarBitacora(Usuario usu, string mensaje)
        {
            BitacoraDAL.InsertarBitacora(usu, mensaje);
        }

        public List<Bitacora> ListarBitacora ()
        {
            return BitacoraDAL.listarBitacora();
        }
        public string VerificarIntegridadTabla()
        { return BitacoraDAL.VerificarIntegridadTabla(); }

        public void comprobarRegistros()
        {
            List<Bitacora> bitacora = new List<Bitacora>();
            bitacora = BitacoraDAL.listarBitacora();
            string auxMensaje = "";
            string auxBitacora = "La tabla Bitacora tiene registros corruptos y son: ";
            bool valBitacora = false;
            foreach (var item in bitacora)
            {
                if (item.estado == "Corrupto")
                {
                    valBitacora = true;
                    auxBitacora += item.id.ToString() + " ";
                }
            }
            
            if (valBitacora)
            {
                auxMensaje += auxBitacora;
                MessageBox.Show(auxMensaje);
                BitacoraDAL.InsertarBitacora((BL.BLSessionManager.GetInstance).Usuario, auxMensaje);
            }
            bitacora.Clear();
        }

    }
}
