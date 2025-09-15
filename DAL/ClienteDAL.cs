using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClienteDAL
    {
        DAO dao = new DAO();

        public Cliente BuscarPorDni(string dni)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@dni", dni }
                };

                var ds = dao.ExecuteDataSet("BuscarClientePorDNI", parametros);

                if (ds.Tables[0].Rows.Count == 0)
                    return null;

                var row = ds.Tables[0].Rows[0];

                return new Cliente
                {
                    IdCliente = Convert.ToInt32(row["IdCliente"]),
                    DNI = row["DNI"].ToString(),
                    Nombre = row["Nombre"].ToString(),
                    Apellido = row["Apellido"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefono = row["Telefono"].ToString()
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error al buscar cliente por DNI", ex);
            }
        }

        public void Insertar(Cliente cliente)
        {
            try
            {
                var parametros = new Dictionary<string, object>
                {
                    { "@dni", cliente.DNI },
                    { "@nombre", cliente.Nombre },
                    { "@apellido", cliente.Apellido },
                    { "@email", cliente.Email },
                    { "@telefono", cliente.Telefono }
                };

                dao.ExecuteNonQuery("InsertarCliente", parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar cliente", ex);
            }
        }

        public List<Cliente> ListarClientes()
        {
            try
            {
                var ds = dao.ExecuteDataSet("ListarClientes");
                var lista = new List<Cliente>();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    lista.Add(new Cliente
                    {
                        IdCliente = Convert.ToInt32(row["IdCliente"]),
                        DNI = row["DNI"].ToString(),
                        Nombre = row["Nombre"].ToString(),
                        Apellido = row["Apellido"].ToString(),
                        Email = row["Email"].ToString(),
                        Telefono = row["Telefono"].ToString()
                    });
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar clientes", ex);
            }
        }
        public List<string> ObtenerTodosLosTiposDeCancha()
        {
            List<string> tipos = new List<string>();

            try
            {
                string commandText = "GetTiposDeCancha";
                var ds = dao.ExecuteDataSet(commandText);

                if (ds.Tables.Count > 0)
                {
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        tipos.Add(row["Tipo"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return tipos;
        }
    }
}
