using BE;
using BL;
using BL.Interfaces;
using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormTraducciones : Form, IObserverIdioma
    {
        Admin Admin;
        BLGestorIdioma gestorIdioma = new BLGestorIdioma();
        private bool isInitializingIdioma = false;

        public FormTraducciones(Admin admin)
        {
            this.Admin = admin;
            InitializeComponent();
            GestorIdioma.Instancia.Agregar(this);
        }

        private void FormTraducciones_Load(object sender, EventArgs e)
        {
            AsignarTagsPorNombre(this);
            EtiquetaHelper.RegistrarEtiquetasDeTodosLosFormularios();

            CargarEtiquetas();
            CargarIdiomas();
            CargarEtiquetasYTraducciones();
            CargarEtiquetasFaltantes();     
            Actualizar(GestorIdioma.Instancia.IdiomaActual);
        }
        private void CargarEtiquetasYTraducciones()
        {
            var datos = gestorIdioma.ObtenerEtiquetasConTraducciones()
                        .Select(t => new { Etiqueta = t.Etiqueta, Idioma = t.Idioma, Traduccion = t.Traduccion })
                        .ToList();
            dgvTraducciones.DataSource = datos;
            dgvTraducciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnAgregarIdioma_Click(object sender, EventArgs e)
        {
            string nuevoNombre = txtNuevoIdioma.Text.Trim();
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                MessageBox.Show("Ingrese un nombre de idioma");
                return;
            }

            var idioma = new Idioma { Nombre = nuevoNombre };
            if (gestorIdioma.InsertarNuevoIdioma(idioma))
            {
                MessageBox.Show("Idioma insertado correctamente");
                CargarIdiomas();
            }
            else
                MessageBox.Show("Error al insertar idioma");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstEtiquetasFaltantes.SelectedItem is string nombreEtiqueta)
            {
                var etiqueta = new Etiqueta { Nombre = nombreEtiqueta };
                if (gestorIdioma.InsertarEtiqueta(etiqueta))
                {
                    MessageBox.Show("Etiqueta insertada");
                    CargarEtiquetas();
                    CargarEtiquetasFaltantes();
                    CargarEtiquetasYTraducciones();
                }
            }
        }
        private void CargarEtiquetasFaltantes()
        {
            var etiquetasDelSistema = EtiquetaHelper.ObtenerEtiquetasRegistradas();
            var faltantes = gestorIdioma.ObtenerEtiquetasFaltantes(etiquetasDelSistema);

            lstEtiquetasFaltantes.Items.Clear();
            foreach (var item in faltantes)
                lstEtiquetasFaltantes.Items.Add(item);
        }
        private void btnGuardarTraduccion_Click(object sender, EventArgs e)
        {
            if (cmbIdiomasExistentes.SelectedItem is Idioma idioma && listEtiquetas.SelectedItem is Etiqueta etiqueta && !string.IsNullOrEmpty(txtTraduccionPorIdioma.Text))
            {
                gestorIdioma.InsertarTraduccion(idioma.Id, etiqueta.Nombre, txtTraduccionPorIdioma.Text.Trim());
                MessageBox.Show("Traducción insertada correctamente.");
                CargarEtiquetasYTraducciones();
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
        }
        private void CargarIdiomas()
        {
            isInitializingIdioma = true;
            var idiomas = gestorIdioma.ObtenerIdiomas();
            cmbIdiomasExistentes.DataSource = idiomas;
            cmbIdiomasExistentes.DisplayMember = "Nombre";
            cmbIdiomasExistentes.ValueMember = "Id";
            isInitializingIdioma = false;
        }

        private void dgvTraducciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AsignarTagsPorNombre(Control control)
        {
            if (control.Tag == null)
                control.Tag = control.Name;

            if (control.Tag != null)
                EtiquetaHelper.Registrar(control.Tag.ToString());

            foreach (Control hijo in control.Controls)
                AsignarTagsPorNombre(hijo);
        }
        private void CargarEtiquetas()
        {
            var etiquetas = gestorIdioma.ObtenerEtiquetas();
            listEtiquetas.DataSource = etiquetas;
            listEtiquetas.DisplayMember = "Nombre";
        }
        public void Actualizar(Idioma idioma)
        {
            if (idioma == null) return;
            var traducciones = gestorIdioma.ObtenerTraducciones(idioma);
            AplicarTraduccion(this, traducciones);
        }
        private void AplicarTraduccion(Control control, Dictionary<string, string> traducciones)
        {
            if (control.Tag != null && traducciones.TryGetValue(control.Tag.ToString(), out string texto))
            {
                control.Text = texto;
            }

            foreach (Control hijo in control.Controls)
            {
                AplicarTraduccion(hijo, traducciones);
            }
        }

        private void listEtiquetas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Admin.Show();
            this.Close();
        }
    }
}
