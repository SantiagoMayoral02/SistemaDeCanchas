using BE;
using BL;
using BL.Interfaces;
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
    public partial class FormRegistrarPago : Form, IObserverIdioma
    {
        Admin admin;
        private BLReserva BLreserva = new BLReserva();
        private BLPago blPago = new BLPago();

        public FormRegistrarPago(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            GestorIdioma.Instancia.Agregar(this);
        }

        private void FormRegistrarPago_Load(object sender, EventArgs e)
        {
            AsignarTagsPorNombre(this);
            cmbMetodoPago.Items.AddRange(new string[] { "Transferencia Bancaria", "Mercado Pago" });
            cmbMetodoPago.SelectedIndex = 0;
            CargarReservasPendientes();
            Actualizar(GestorIdioma.Instancia.IdiomaActual);
        }
        private void CargarReservasPendientes()
        {
            dgvReservasPendientes.DataSource = BLreserva.ObtenerReservasPendientes();
            dgvReservasPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmListadoReservas frmListadoReservas = new frmListadoReservas(admin);
            frmListadoReservas.Show();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvReservasPendientes.CurrentRow?.DataBoundItem is Reserva reserva)
            {
                var pago = new Pago
                {
                    ReservaId = reserva.IdReserva,
                    FechaPago = DateTime.Now,
                    Monto = reserva.Total,
                    MetodoPago = cmbMetodoPago.SelectedItem.ToString()
                };
                blPago.RegistrarPago(pago);
                MessageBox.Show("Pago confirmado.");
                CargarReservasPendientes();
            }
        }
        private void AsignarTagsPorNombre(Control c)
        {
            if (c.Tag == null) c.Tag = c.Name;
            foreach (Control hijo in c.Controls)
                AsignarTagsPorNombre(hijo);
        }

        public void Actualizar(Idioma idioma)
        {
            var traducciones = new BLGestorIdioma().ObtenerTraducciones(idioma);
            AplicarTraduccion(this, traducciones);
        }
        private void AplicarTraduccion(Control control, Dictionary<string, string> traducciones)
        {
            if (control.Tag != null && traducciones.TryGetValue(control.Tag.ToString(), out var texto))
                control.Text = texto;

            foreach (Control hijo in control.Controls)
                AplicarTraduccion(hijo, traducciones);
        }

        private void dgvReservasPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
