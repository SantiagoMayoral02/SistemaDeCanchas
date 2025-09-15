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
    public partial class FormMantenimientoCanchas : Form, IObserverIdioma
    {
        Admin admin;
        private BLMantenimiento blMantenimiento = new BLMantenimiento();
        CanchaBL blCancha = new CanchaBL();

        public FormMantenimientoCanchas(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            GestorIdioma.Instancia.Agregar(this);
        }

        private void FormMantenimientoCanchas_Load(object sender, EventArgs e)
        {
            AsignarTagsPorNombre(this);
            cmbCanchas.DataSource = blCancha.ObtenerTodasLasCanchas();
            cmbCanchas.DisplayMember = "Nombre";
            cmbCanchas.ValueMember = "IdCancha";
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            var mantenimiento = new Mantenimiento
            {
                CanchaId = (int)cmbCanchas.SelectedValue,
                FechaInicio = dtpInicio.Value,
                FechaFin = dtpFin.Value,
                Motivo = txtMotivo.Text.Trim()
            };
            blMantenimiento.ProgramarMantenimiento(mantenimiento);
            MessageBox.Show("Mantenimiento programado correctamente");
        }
    }
}
