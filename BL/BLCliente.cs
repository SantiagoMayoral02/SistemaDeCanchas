using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class ClienteBL
    {
       ClienteDAL clienteDal = new ClienteDAL();

        public Cliente BuscarPorDni(string dni)
        {
            return clienteDal.BuscarPorDni(dni);
        }

        public void Insertar(Cliente cliente)
        {
            clienteDal.Insertar(cliente);
        }

        public List<Cliente> ListarTodos()
        {
            return clienteDal.ListarClientes();
        }
    }
}
