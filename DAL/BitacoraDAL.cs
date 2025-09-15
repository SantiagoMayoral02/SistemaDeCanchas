using BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class BitacoraDAL
    {
        DAO dAO = new DAO();
        
        public void InsertarBitacora(Usuario usu, string mensaje)
        {
            try
            {

                string commandText = "InsertarBitacora";
                var parametros = new Dictionary<string, object>
                {
                    { "@idUsuario", usu.Id },
                    { "@mensaje", mensaje },
                    { "@fecha", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") }
                };
                dAO.ExecuteNonQuery(commandText, parametros);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public string VerificarIntegridadTabla()
        {
            string resultado = "";
            try
            {
                string commandText = "VerificarIntegridadTabla";
                DAO dAO = new DAO();
                resultado = dAO.ExecuteScalarString(commandText);
            }
            catch (Exception e)
            {
                throw e;
            }
            return resultado;
        }
        public List<Bitacora> listarBitacora()
        {
            List<Bitacora> listBit = new List<Bitacora>();
            try
            {
                string commandText = "ListarRegistrosBitacora";
                DAO dAO = new DAO();
                DataSet ds = dAO.ExecuteDataSet(commandText);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        Bitacora bitacora = new Bitacora();
                        bitacora.id = Convert.ToInt32(row["id_bitacora"]);
                        bitacora.idUsuario = Convert.ToInt32(row["idUsuario"]);
                        bitacora.fecha = Convert.ToDateTime(row["fecha"]);
                        bitacora.mensaje = row["mensaje"].ToString();
                        bitacora.estado = row["Estado"].ToString();
                        listBit.Add(bitacora);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return listBit;
        }
    }
}
