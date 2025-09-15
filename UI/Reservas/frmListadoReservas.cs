using BE;
using BL;
using Seguridad;
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
    public partial class frmListadoReservas : Form
    {
        Admin admin;
        private Usuario usuario;
        private BLReserva reservaBL = new BLReserva();
        public frmListadoReservas(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void frmListadoReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
            ConfigurarBotonesPorRol();
            dgvReservas.SelectionChanged += dgvReservas_SelectionChanged;
        }
        private void CargarReservas()
        {
            var reservas = reservaBL.ObtenerTodasLasReservas();
            dgvReservas.DataSource = reservas;

            dgvReservas.Columns["NombreCliente"].HeaderText = "Cliente";
            dgvReservas.Columns["NombreCancha"].HeaderText = "Cancha";
            dgvReservas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvReservas.Columns["HoraInicio"].DefaultCellStyle.Format = @"hh\:mm"; //Duración horas y total
            dgvReservas.Columns["IdCancha"].Visible = false;
            dgvReservas.Columns["IdCliente"].Visible = false;
            dgvReservas.Columns["IdReserva"].Visible = false;
            dgvReservas.Columns["Estado"].Visible = false;
            ColorearFilasPorEstado();

            btnRegistrarPago.Enabled = false;
            btnCancelarReserva.Enabled = false;
        }
        private void ColorearFilasPorEstado()
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                string estado = row.Cells["Estado"].Value.ToString();

                switch (estado)
                {
                    case "Reservado":
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    case "Pendiente":
                        row.DefaultCellStyle.BackColor = Color.LightYellow;
                        break;
                    case "Cancelado":
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                        break;
                }
            }
        }
        private void dgvReservas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                var reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;

                btnRegistrarPago.Enabled = reserva.Estado == "Pendiente";
                btnCancelarReserva.Enabled = reserva.Estado == "Pendiente";
            }
            else
            {
                btnRegistrarPago.Enabled = false;
                btnCancelarReserva.Enabled = false;
            }
        }
        private void ConfigurarBotonesPorRol()
        {
            btnCancelarReserva.Visible = PermisoHelper.UsuarioTienePermiso(BLSessionManager.GetInstance.Usuario, "PuedeReservar"); // Recepcionista
            btnRegistrarPago.Visible = PermisoHelper.UsuarioTienePermiso(BLSessionManager.GetInstance.Usuario, "PuedeConfirmarPagos");   // Cajero
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
             FormRegistrarPago formPago = new FormRegistrarPago(admin);
             formPago.Show();
             this.Hide();
                 
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                var reserva = (Reserva)dgvReservas.SelectedRows[0].DataBoundItem;

                if (reserva.Estado == "Pendiente")
                {
                    reservaBL.CancelarReserva(reserva.IdReserva);
                    MessageBox.Show("Reserva cancelada correctamente.");
                    CargarReservas();
                }
                else
                {
                    MessageBox.Show("Solo puede cancelar reservas en estado Pendiente.");
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }
    }
}
