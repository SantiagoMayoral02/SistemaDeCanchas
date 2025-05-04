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
        public string VerificarIntegridadTabla()
        { return BitacoraDAL.VerificarIntegridadTabla(); }

        public void comprobarRegistros()
        {
            List<BE.Bitacora> bitacora = new List<BE.Bitacora>();
            bitacora = BitacoraDAL.listarBitacora();
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
            string auxMensaje = "";
            if (valBitacora)
            {
                auxMensaje += auxBitacora;
            }
            if (valBitacora)
            {
                MessageBox.Show(auxMensaje);
                BitacoraDAL.InsertarBitacora((BL.BLSessionManager.GetInstance).Usuario, auxMensaje);
            }
            bitacora.Clear();
        }

    }
}
