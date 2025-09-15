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

namespace UI.Canchas
{
    public partial class ModificacionCanchas : Form, IObserverIdioma
    {
        Admin admin;
        CanchaBL conexion = new CanchaBL();
        int idCeldaSeleccionada;
        string nombreCancha;
        string descripcionCancha;
        decimal precioCancha;
        public ModificacionCanchas(Admin admin)
        {
            this.admin = admin;
            InitializeComponent();
            GestorIdioma.Instancia.Agregar(this);
        }
        private void ModificacionCanchas_Load(object sender, EventArgs e)
        {
            AsignarTagsPorNombre(this);
            Actualizar(GestorIdioma.Instancia.IdiomaActual);
            CargarDGV();
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
        private void CargarDGV()
        {
            dataGridView1.DataSource = conexion.ObtenerTodasLasCanchas()
                .Select(c => new
                {
                    c.Nombre,
                    c.PrecioHora,
                    c.Descripcion,
                    TipoCancha = c.GetTipoCancha().Nombre,
                })
                .OrderBy(c => c.TipoCancha)
                .ToList();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }

        private void btnCambioNombre_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !(string.IsNullOrWhiteSpace(txtCambioNombre.Text)))
            {
                ObtenerDatosDGV();

                conexion.ActualizarNombreCancha(idCeldaSeleccionada, txtCambioNombre.Text);
                MessageBox.Show("El nombre de la cancha '" + nombreCancha + "' fue modificado correctamente por: " + txtCambioNombre.Text);
                
                CargarDGV();
                VaciarCampos();
            }
            else
                MessageBox.Show("Debe seleccionar una cancha y completar el campo del nuevo nombre");
        }

        private void btnNuevaDescrip_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !(string.IsNullOrWhiteSpace(txtNuevaDescrip.Text)))
            {
                ObtenerDatosDGV();

                conexion.ActualizarDescripcionCancha(idCeldaSeleccionada, txtNuevaDescrip.Text);
                MessageBox.Show("La descripción de la cancha '" + nombreCancha + "' fue modificado correctamente por la siguiente: " + txtNuevaDescrip.Text);

                CargarDGV();
                VaciarCampos();
            }
            else
                MessageBox.Show("Debe seleccionar una cancha y completar el campo de la nueva descripcion");
        }

        private void btnNuevoPrecio_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !(string.IsNullOrWhiteSpace(txtNuevoPrecio.Text)))
            {
                ObtenerDatosDGV();

                conexion.ActualizarPrecioCancha(idCeldaSeleccionada, Decimal.Parse(txtNuevoPrecio.Text));
                MessageBox.Show("El precio de la cancha '" + nombreCancha + "' fue modificado correctamente por el siguiente: " + txtNuevoPrecio.Text);

                CargarDGV();
                VaciarCampos();
            }
            else
                MessageBox.Show("Debe seleccionar una cancha y completar el campo del nuevo precio");
        }
        private void ObtenerDatosDGV()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            idCeldaSeleccionada = int.Parse(selectedRow.Cells[0].Value.ToString());
            nombreCancha = selectedRow.Cells[1].Value.ToString();
            precioCancha = Decimal.Parse(selectedRow.Cells[2].Value.ToString());
            descripcionCancha = selectedRow.Cells[3].Value.ToString();
        }
        private void VaciarCampos()
        {
            txtCambioNombre.Clear();
            txtNuevaDescrip.Clear();
            txtNuevoPrecio.Clear();
        }
    }
}
