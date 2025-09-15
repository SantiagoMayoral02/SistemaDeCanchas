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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormGestionUsuario : Form, IObserverIdioma
    {
        private Admin admin;
        private BLPermiso BLPermiso;
        private Usuario seleccion;
        private BLUsuarioConexion BLUsuario;
        private Usuario tmp;
        private BLGestorIdioma blGestorIdioma = new BLGestorIdioma();
        private bool isInitializingComboBox = false;

        public FormGestionUsuario(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            BLPermiso = new BLPermiso();
            BLUsuario = new BLUsuarioConexion();
            GestorIdioma.Instancia.Agregar(this);
            this.cboUsuarios.DataSource = BLUsuario.ObtenerUsuarios();
            this.cboPatentes.DataSource = BLPermiso.GetAllPatentes();
            this.cboFamilias.DataSource = BLPermiso.GetAllFamilias();
        }

        private void FormGestionUsuario_Load(object sender, EventArgs e)
        {
            AsignarTagsPorNombre(this);
            LlenarComboIdiomas();
            btnAgregarFamilia.Enabled = false;
            btnAgregarPatente.Enabled = false;
            btnGuardarCambios.Enabled = false;
            Actualizar(GestorIdioma.Instancia.IdiomaActual);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            admin.Show();
            this.Close();
        }
        private void AsignarTagsPorNombre(Control control)
        {
            if (control.Tag == null)
                control.Tag = control.Name;

            EtiquetaHelper.Registrar(control.Tag?.ToString());

            foreach (Control hijo in control.Controls)
                AsignarTagsPorNombre(hijo);
        }
        private void LlenarComboIdiomas()
        {
            isInitializingComboBox = true;

            var idiomas = blGestorIdioma.ObtenerIdiomas();
            cmbIdioma.DataSource = idiomas;
            cmbIdioma.DisplayMember = "Nombre";
            cmbIdioma.ValueMember = "Id";

            Idioma idiomaActual = GestorIdioma.Instancia.IdiomaActual;

            if (idiomaActual != null)
            {
                var seleccionado = idiomas.FirstOrDefault(i => i.Id == idiomaActual.Id);
                if (seleccionado != null)
                {
                    cmbIdioma.SelectedItem = seleccionado;
                    GestorIdioma.Instancia.CambiarIdioma(seleccionado); // fuerza notificación
                }
                isInitializingComboBox = false;
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

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializingComboBox && cmbIdioma.SelectedItem is Idioma idiomaSeleccionado)
            {
                GestorIdioma.Instancia.CambiarIdioma(idiomaSeleccionado);
            }
        }
        public void Actualizar(Idioma idioma)
        {
            if (idioma == null) return;
            var traducciones = blGestorIdioma.ObtenerTraducciones(idioma);
            AplicarTraduccion(this, traducciones);

            //foreach (Control ctrl in this.Controls)
            //{
            //    AplicarTraduccion(ctrl, traducciones);
            //}
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                BLPermiso.GuardarPermisoUsuario(tmp);
                MessageBox.Show("Usuario guardado correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al guardar el usuario");
            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var flia = (Familia)cboFamilias.SelectedItem;
                if (flia != null)
                {
                    var esta = false;
                    //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                    foreach (var item in tmp.Permisos)
                    {
                        if (BLPermiso.Existe(item, flia.Id))
                        {
                            esta = true;
                        }
                    }

                    if (esta)
                        MessageBox.Show("El usuario ya tiene la familia indicada");
                    else
                    {
                        {
                            BLPermiso.FillFamilyComponents(flia);
                            tmp.Permisos.Add(flia);
                            MostrarPermisos(tmp);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una familia.");
                }
            }
            else
            {
                MessageBox.Show("Debe configurar un usuario primero.");
            }
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            if (tmp != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = false;

                    foreach (var item in tmp.Permisos)
                    {
                        if (BLPermiso.Existe(item, patente.Id))
                        {
                            esta = true;
                            break;
                        }
                    }
                    if (esta)
                        MessageBox.Show("El usuario ya tiene la patente indicada");
                    else
                    {
                            tmp.Permisos.Add(patente);
                            MostrarPermisos(tmp);
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una patente.");
                }
            }
            else
            {
                MessageBox.Show("Debe configurar un usuario primero.");
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            seleccion = (Usuario)cboUsuarios.SelectedItem;

            if (seleccion != null)
            {
                tmp = new Usuario
                {
                    Id = seleccion.Id,
                    Nombre = seleccion.Nombre
                };
                tmp.Permisos.Clear(); 

                BLPermiso.FillUserComponents(tmp);

                MostrarPermisos(tmp);
                btnAgregarFamilia.Enabled = true;
                btnAgregarPatente.Enabled = true;
                btnGuardarCambios.Enabled = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario.");
            }
        }
        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }

        }
        void MostrarPermisos(Usuario u)
        {
            this.treeConfigFamilia.Nodes.Clear();
            TreeNode root = new TreeNode(u.Nombre);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeConfigFamilia.Nodes.Add(root);
            this.treeConfigFamilia.ExpandAll();
        }
    }
}
