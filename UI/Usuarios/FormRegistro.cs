using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Seguridad;

namespace UI
{
    public partial class FormRegistro : Form
    {
        BLUsuarioConexion conexion = new BLUsuarioConexion();
        BLBitacora bitacora = new BLBitacora();
        Encrypting encryptManager = new Encrypting();
        Admin admin;
        public FormRegistro(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormRegistro_Load(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Ingreso a la pantalla de registro");
            lblUsu.Text = BLSessionManager.GetInstance.Usuario.Nombre;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNom.Text;
            string contra = txtPass.Text;
            if(ValidarCamposUsuario(nombre, contra))
            {
                string contraCrypt = encryptManager.ObtenerHash(contra);
                if(conexion.CrearUsuario(nombre, contraCrypt) == 0)
                {
                    MessageBox.Show("Error al crear el usuario");
                    return;
                }
                MessageBox.Show("Usuario creado correctamente");
                bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Creación de usuario: " + nombre);
                txtNom.Clear();
                txtPass.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese valores en nombre y contraseña correctos");
            }
        }

        private bool ValidarCamposUsuario(string nombre, string contra)
        {
            return true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora(BLSessionManager.GetInstance.Usuario, "Vuelta a la pantalla admin desde registro");
            admin.Show();
            this.Close();
        }
    }
}
