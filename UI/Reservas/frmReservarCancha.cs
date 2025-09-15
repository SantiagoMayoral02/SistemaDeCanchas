using BE;
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

namespace UI
{
    public partial class frmReservarCancha : Form
    {
        Admin admin;
        private BLReserva reservaBL = new BLReserva();
        private ClienteBL clienteBL = new ClienteBL();
        private CanchaBL canchaBL = new CanchaBL();

        private Cliente clienteSeleccionado;

        public frmReservarCancha(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
        }

        private void frmReservarCancha_Load(object sender, EventArgs e)
        {
            var tipos = canchaBL.ObtenerTodosLosTiposDeCancha();
            cmbTipoCancha.DataSource = tipos;
            cmbTipoCancha.DisplayMember = "Nombre";
            cmbTipoCancha.ValueMember = "IdTipoCancha"; 

            cmbHoraInicio.Items.Clear();
            for (int h = 8; h <= 22; h++)
                cmbHoraInicio.Items.Add(new TimeSpan(h, 0, 0).ToString());

            cmbHoraInicio.SelectedIndex = 0;
            numDuracionHoras.Value = 1;

            cmbTipoCancha.SelectedIndexChanged += ActualizarCanchasDisponiblesHandler;
            dtpFecha.ValueChanged += ActualizarCanchasDisponiblesHandler;
            cmbHoraInicio.SelectedIndexChanged += ActualizarCanchasDisponiblesHandler;
            cmbCanchasDisponibles.SelectedIndexChanged += ActualizarPrecioFinalHandler; //ValidarEstadoConfirmacion();
            numDuracionHoras.ValueChanged += ActualizarPrecioFinalHandler;
            numDuracionHoras.ValueChanged += ActualizarCanchasDisponiblesHandler;
        }
        private void ActualizarCanchasDisponiblesHandler(object sender, EventArgs e) => ActualizarCanchasDisponibles();
        private void ActualizarPrecioFinalHandler(object sender, EventArgs e) => ActualizarPrecioFinal();
        private void ActualizarCanchasDisponibles()
        {
            if (cmbTipoCancha.SelectedItem == null || cmbHoraInicio.SelectedItem == null) return;

            TipoCancha tipoSeleccionado = cmbTipoCancha.SelectedItem as TipoCancha;
            string nombreTipoSeleccionado = tipoSeleccionado.Nombre;
            DateTime fecha = dtpFecha.Value.Date;
            TimeSpan horaInicio = TimeSpan.Parse(cmbHoraInicio.SelectedItem.ToString());
            int duracion = (int)numDuracionHoras.Value;

            var todasLasCanchas = canchaBL.ObtenerCanchasPorTipo(nombreTipoSeleccionado);

            var disponibles = todasLasCanchas.Where(c =>
                reservaBL.VerDisponibilidad(c.IdCancha, fecha, horaInicio, duracion)
            ).ToList();

            cmbCanchasDisponibles.DataSource = disponibles;
            cmbCanchasDisponibles.DisplayMember = "Nombre";
            cmbCanchasDisponibles.ValueMember = "IdCancha";

            lblEstadoDispo.Text = disponibles.Any() ? "Hay canchas disponibles para reservar" : "No hay canchas disponibles para reservar";
            lblEstadoDispo.ForeColor = disponibles.Any() ? Color.Green : Color.Red;

            btnConfirmarReserva.Enabled = disponibles.Any() && clienteSeleccionado != null;
        }
        private void ActualizarPrecioFinal()
        {
            if (cmbCanchasDisponibles.SelectedItem is Cancha cancha)
            {
                int duracion = (int)numDuracionHoras.Value;
                decimal total = cancha.PrecioHora * duracion;
                lblPrecioFinal.Text = $"Total: ${total}";
            }
            else
            {
                lblPrecioFinal.Text = "Total: -";
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmarReserva_Click_1(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            DateTime fecha = dtpFecha.Value.Date;
            TimeSpan horaInicio = TimeSpan.Parse(cmbHoraInicio.SelectedItem.ToString());
            int duracion = (int)numDuracionHoras.Value;
            int idCancha = (int)cmbCanchasDisponibles.SelectedValue;
            Cancha cancha = canchaBL.ObtenerCanchaPorId(idCancha);
            string metodoPago = rbtnEfectivo.Checked ? "Efectivo" : "Mercado Pago";

            decimal total = cancha.PrecioHora * duracion;

            Reserva reserva = new Reserva
            {
                IdCliente = clienteSeleccionado.IdCliente,
                IdCancha = idCancha,
                Fecha = fecha,
                HoraInicio = horaInicio,
                DuracionHoras = duracion,
                Total = total,
                Estado = metodoPago == "Efectivo" ? "Reservado" : "Pendiente",
                NombreCancha = cancha.Nombre // Para estadísticas
            };

            reservaBL.InsertarReserva(reserva);
            MessageBox.Show("Reserva registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarFormulario();
            labelNombreCliente.Text = "Vuelva a seleccionar un cliente";
        }


        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            string dni = txtDNICliente.Text.Trim();
            clienteSeleccionado = clienteBL.BuscarPorDni(dni);

            if (clienteSeleccionado == null)
            {
                if (MessageBox.Show("Cliente no registrado. ¿Desea registrarlo?", "Nuevo cliente", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    frmClientes form = new frmClientes(dni);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        clienteSeleccionado = form.ClienteCreado;
                    }
                }
            }
            else
            {
                labelNombreCliente.Text = $"Cliente {clienteSeleccionado.Nombre} {clienteSeleccionado.Apellido}";
                ActualizarCanchasDisponibles();
            }
        }
        private void LimpiarFormulario()
        {
            clienteSeleccionado = null;
            lblNombreCliente.Text = "";
            txtDNICliente.Clear();
            ActualizarCanchasDisponibles();
        }
        private bool ValidarCampos()
        {
            bool valid = true;
            Action<Control> marcarError = c => { c.BackColor = Color.MistyRose; valid = false; };
            Action<Control> limpiarError = c => c.BackColor = SystemColors.Window;

            if (clienteSeleccionado == null) marcarError(txtDNICliente); else limpiarError(txtDNICliente);
            if (cmbTipoCancha.SelectedItem == null) marcarError(cmbTipoCancha); else limpiarError(cmbTipoCancha);
            if (cmbHoraInicio.SelectedItem == null) marcarError(cmbHoraInicio); else limpiarError(cmbHoraInicio);
            if (cmbCanchasDisponibles.SelectedItem == null) marcarError(cmbCanchasDisponibles); else limpiarError(cmbCanchasDisponibles);
            if (rbtnEfectivo.Checked == false && rbtnMPago.Checked == false) marcarError(lblMetodoPago); else limpiarError(lblMetodoPago);

            if (!valid)
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return valid;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }

        private void btnVerReservas_Click(object sender, EventArgs e)
        {
            frmListadoReservas reservasForm = new frmListadoReservas(admin);
            reservasForm.Show();
            this.Close();
        }
    }
}
