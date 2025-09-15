using BE;
using BL;
using BL.Interfaces;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form, IObserverIdioma
    {
        BLUsuarioConexion BLUsu = new BLUsuarioConexion();
        BLBitacora BLBita = new BLBitacora();
        public string nom;
        public string pass;
        BLGestorIdioma gestor = new BLGestorIdioma();
        public Form1()
        {
            InitializeComponent();
            txtContra.UseSystemPasswordChar = true;
            this.AcceptButton = btnLogin;
            if (HayDatosCorruptos())
                MessageBox.Show("Checksum de tabla bitacora alterado");
            GestorIdioma.Instancia.Agregar(this);
            
            /*Actualizar(GestorIdioma.Instancia.IdiomaActual);*/  //Acá llamar al idioma por defecto, por ejemplo Español (lukitas)
        }
        //private void 
        //if(digitoVerificador.comprobarTablas())
        //    {
        //        button1.Enabled = false;
        //        button2.Enabled = true;
        //        button2.Visible = true;
        //    }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidarIngresoDeCampos())
            {
                nom = txtNombre.Text;
                pass = txtContra.Text;
                Usuario usu = BLUsu.ValidarUsuario(nom, pass);
                if (usu != null)
                {
                    BLSessionManager.login(usu);
                    BLBita.InsertarBitacora((BL.BLSessionManager.GetInstance).Usuario, "Ingreso de usuario");
                    new Admin(this).Show();
                    this.Hide();
                }
            }
        }
        
        private bool ValidarIngresoDeCampos()
        {
            nom = txtNombre.Text.Trim();
            pass = txtContra.Text.Trim();
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Debe completar usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //FormRegistro formRegistro = new FormRegistro();
        //    //formRegistro.Show();
        //}
        private bool HayDatosCorruptos()
        {
            string resultado = BLBita.VerificarIntegridadTabla();
            if (resultado == "La tabla ha sido alterada o se ha eliminado un registro.")
            {
                MessageBox.Show("La tabla bitacora tiene registros alterados o eliminados");
                return true;
            }
            return false;
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarComboIdiomas();
            AsignarTagsPorNombre(this);

        }
        private void AsignarTagsPorNombre(Control control)
        {
            if (control.Tag == null)
                control.Tag = control.Name;

            EtiquetaHelper.Registrar(control.Tag?.ToString());

            foreach (Control hijo in control.Controls)
                AsignarTagsPorNombre(hijo);
        }
        public void Actualizar(Idioma idioma)
        {
            var traducciones = gestor.ObtenerTraducciones(idioma);

            foreach (Control ctrl in this.Controls)
            {
                AplicarTraduccion(ctrl, traducciones);
            }
        }
        private void AplicarTraduccion(Control control, Dictionary<string, string> traducciones)
        {
            if (control.Tag != null)
            {
                string clave = control.Tag.ToString();
                if (traducciones.TryGetValue(clave, out string texto))
                {
                    control.Text = texto;
                }
            }
            foreach (Control hijo in control.Controls) //Si el control posee hijos, aplicar traducción recursivamente
            {
                AplicarTraduccion(hijo, traducciones);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializingComboBox && cmbIdioma.SelectedItem is Idioma idiomaSeleccionado)
            {
                GestorIdioma.Instancia.CambiarIdioma(idiomaSeleccionado);
            }
        }
        private bool isInitializingComboBox = false;
        private void LlenarComboIdiomas()
        {
            isInitializingComboBox = true;

            var idiomas = gestor.ObtenerIdiomas();
            cmbIdioma.DataSource = idiomas;
            cmbIdioma.DisplayMember = "Nombre";
            cmbIdioma.ValueMember = "Id";

            // Usar idioma actual si está definido
            Idioma idiomaActual = GestorIdioma.Instancia.IdiomaActual;

            if (idiomaActual != null)
            {
                cmbIdioma.SelectedItem = idiomas.FirstOrDefault(i => i.Id == idiomaActual.Id);
            }
            else
            {
                var idiomaPorDefecto = idiomas.FirstOrDefault(i => i.Nombre.ToLower() == "español");
                if (idiomaPorDefecto != null)
                {
                    cmbIdioma.SelectedItem = idiomaPorDefecto;
                    GestorIdioma.Instancia.CambiarIdioma(idiomaPorDefecto);
                }

                isInitializingComboBox = false;
            }
        }
    }
}
