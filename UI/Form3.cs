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
    public partial class RegistroForm : Form
    {
        BLUsuarioConexion BLUsu = new BLUsuarioConexion();
        Encrypting encryptor = new Encrypting();    
        public RegistroForm()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string contra = txtContra.Text;
            if (ValidarFormatoUsuario(nombre, contra))
            {
                string contraCrypt = encryptor.ObtenerHash(contra);
                if(BLUsu.CrearUsuario(nombre, contraCrypt) == 0)
                {
                    MessageBox.Show("Error al crear el usuario");
                    return;
                }
                MessageBox.Show("Usuario creado con éxito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al crear el usuario");
            }
        }

        private bool ValidarFormatoUsuario(string nombre, string contra)
        {
            return true;
        }
    }
}
