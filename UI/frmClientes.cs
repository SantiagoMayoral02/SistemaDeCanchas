using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmClientes : Form
    {
        public Cliente ClienteCreado { get; private set; }
        public frmClientes(string dni)
        {
            InitializeComponent();
            txtDNI.Text = dni;
        }
        public frmClientes() : this(string.Empty) { }
        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            Cliente nuevo = new Cliente
            {
                DNI = txtDNI.Text,
                Nombre = txtUsuario.Text,
                Apellido = txtApellido.Text,
                Email = txtMail.Text,
                Telefono = txtTelefono.Text
            };

            ClienteBL clienteBL = new ClienteBL();
            clienteBL.Insertar(nuevo);
            ClienteCreado = nuevo;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
