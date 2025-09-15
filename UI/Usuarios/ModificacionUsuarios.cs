using BE;
using BL;
using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ModificacionUsuarios : Form
    {
        BLUsuarioConexion conexion = new BLUsuarioConexion();
        BLBitacora bitacora = new BLBitacora();
        Encrypting EncryptManager = new Encrypting();
        Admin admin;
        int idCeldaSeleccionada;
        string nombreUsuario;
        bool estaBloqueado = false;
        public ModificacionUsuarios(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
        private void ModificacionUsuarios_Load(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Ingreso a la pantalla de modificacion de usuarios");
            lblUsu.Text = (BLSessionManager.GetInstance).Usuario.Nombre;
            CargarDGV();
        }
        
        private void btnVolver_Click(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora(BLSessionManager.GetInstance.Usuario, "Vuelta a la pantalla admin desde modificacion de usuarios");
            admin.Show();
            this.Close();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0 && !(string.IsNullOrWhiteSpace(txtNom.Text)))
            {
                ObtenerDatosDGV();
                if (conexion.CambiarNombreUsuario(idCeldaSeleccionada, txtNom.Text) == 1)
                {
                    MessageBox.Show("El nombre del usuario " + nombreUsuario + " fue modificado correctamente por: " + txtNom.Text);
                    CargarDGV();
                    bitacora.InsertarBitacora(BLSessionManager.GetInstance.Usuario, "El nombre del usuario "+ nombreUsuario + " fue modificado correctamente por: "+txtNom.Text);
                    VaciarCampos();
                }
                else 
                    MessageBox.Show("No se pudo actualizar el usuario");
            }
            else
            {
                MessageBox.Show("No se ingresó el nuevo nombre para el usuario");
            }
        }

        private void btnContra_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !(string.IsNullOrWhiteSpace(txtContra.Text)))
            {
                ObtenerDatosDGV();
                string nuevaContra = EncryptManager.ObtenerHash(txtContra.Text);
                if (conexion.CambiarContraseña(idCeldaSeleccionada, nuevaContra) == 1)
                {
                    MessageBox.Show("Contraseña de " + nombreUsuario + " modificada correctamente");
                    CargarDGV();
                    bitacora.InsertarBitacora(BLSessionManager.GetInstance.Usuario, "Contraseña de "+ nombreUsuario + " modificada correctamente");
                    VaciarCampos();
                }
                else
                    MessageBox.Show("No se pudo actualizar el usuario");
            }
            else
            {
                MessageBox.Show("No se ingresó la nueva contraseña para el usuario");
            }
        }
        private void VaciarCampos()
        {
            txtNom.Clear();
            txtContra.Clear();
        }
        private void CargarDGV()
        {
            dataGridView1.DataSource = conexion.ObtenerUsuarios();
            dataGridView1.Columns.RemoveAt(3);
        }
        private void ObtenerDatosDGV()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            idCeldaSeleccionada = int.Parse(selectedRow.Cells[0].Value.ToString());
            nombreUsuario = selectedRow.Cells[1].Value.ToString();
            estaBloqueado = bool.Parse(selectedRow.Cells[2].Value.ToString());
        }

        private void btnDesbloqueo_Click(object sender, EventArgs e)
        {
            ObtenerDatosDGV();
            if (estaBloqueado)
            {
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro que deseas desbloquear este usuario?",
                    "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes && estaBloqueado)
                {
                    try
                    {
                        conexion.DesbloquearUsuario(idCeldaSeleccionada);
                        MessageBox.Show("Usuario desbloqueado correctamente.");
                        CargarDGV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al desbloquear: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccioná un usuario bloqueado para desbloquear.");
            }
        }
    }
}
   