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
    public partial class FormCrearCancha : Form, IObserverIdioma
    {
        Admin admin;
        Cancha nuevaCancha;
        TipoCancha nuevoTipoCancha;
        CanchaBL canchaBL = new CanchaBL();
        public FormCrearCancha(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
            GestorIdioma.Instancia.Agregar(this);
        }

        private void FormCrearCancha_Load(object sender, EventArgs e)
        {
            AsignarTagsPorNombre(this);
            ActualizarTiposDeCancha();
            Actualizar(GestorIdioma.Instancia.IdiomaActual);
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }

        private void btnConfirmTipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNuevoTipoCancha.Text))
            {
                MessageBox.Show("El nombre del nuevo tipo de cancha no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nuevoTipoCancha = new TipoCancha
            { Nombre = txtNuevoTipoCancha.Text };

            canchaBL.InsertarNuevoTipoCancha(nuevoTipoCancha);
            ActualizarTiposDeCancha();
            MessageBox.Show("Nuevo tipo de cancha insertado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfirmCancha_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (!ValidarPrecio()) return;
            nuevaCancha = new Cancha((TipoCancha)cmbTipoCancha.SelectedItem)
            {
                Nombre = txtNombreNuevaCancha.Text,
                Descripcion = txtDescripcionCancha.Text,
                PrecioHora = int.Parse(txtPrecio.Text)
            };
            canchaBL.InsertarNuevaCancha(nuevaCancha);
            MessageBox.Show("Nueva cancha insertada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool ValidarCampos()
        {
            bool valid = true;
            Action<Control> marcarError = c => { c.BackColor = Color.MistyRose; valid = false; };
            Action<Control> limpiarError = c => c.BackColor = SystemColors.Window;

            if (string.IsNullOrEmpty(txtNombreNuevaCancha.Text)) marcarError(txtNombreNuevaCancha); else limpiarError(txtNombreNuevaCancha);
            if (string.IsNullOrEmpty(txtDescripcionCancha.Text)) marcarError(txtDescripcionCancha); else limpiarError(txtDescripcionCancha);
            if (cmbTipoCancha.SelectedItem == null) marcarError(cmbTipoCancha); else limpiarError(cmbTipoCancha);
            if (string.IsNullOrEmpty(txtPrecio.Text)) marcarError(txtPrecio); else limpiarError(txtPrecio);

            if (!valid)
                MessageBox.Show("Debe completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return valid;
        }
        private bool ValidarPrecio()
        {
            bool valid = true;
            Action<Control> marcarError = c => { c.BackColor = Color.MistyRose; valid = false; };
            Action<Control> limpiarError = c => c.BackColor = SystemColors.Window;

            int precio;
            if (!int.TryParse(txtPrecio.Text, out precio))
            {
                marcarError(txtPrecio);
                MessageBox.Show("El precio debe ser un valor numérico mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            limpiarError(txtPrecio);

            return valid;
        }
        private void ActualizarTiposDeCancha()
        {
            var tipos = canchaBL.ObtenerTodosLosTiposDeCancha();
            cmbTipoCancha.DataSource = null;
            cmbTipoCancha.DataSource = tipos;
            cmbTipoCancha.DisplayMember = "Nombre";
            cmbTipoCancha.ValueMember = "IdTipoCancha";
        }
    }
}
