using BE;
using BL;
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
    public partial class FormPatentesFamilias : Form
    {
        Admin admin;
        BLPermiso BLPermiso;
        Familia seleccion;
        public FormPatentesFamilias(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            BLPermiso = new BLPermiso();
            this.cboPermisos.DataSource = BLPermiso.GetAllPermission();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPatentesFamilias_Load(object sender, EventArgs e)
        {
            LlenarPatentesFamilias();   
        }
        private void LlenarPatentesFamilias()
        {
            //llenarComboLenguaje();
            this.cboPatentes.DataSource = BLPermiso.GetAllPatentes();
            this.cboFamilias.DataSource = BLPermiso.GetAllFamilias();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //admin.LlenarComboLenguaje();
            admin.Show();
            this.Close();
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var patente = (Patente)cboPatentes.SelectedItem;
                if (patente != null)
                {
                    var esta = BLPermiso.Existe(seleccion, patente.Id);
                    if (esta)
                        MessageBox.Show("ya exsite la patente indicada");
                    else
                    {
                      seleccion.AgregarHijo(patente);
                      MostrarFamilia(false);
                    }
                }
            }
        }
        void MostrarFamilia(bool init)
        {
            if (seleccion == null) return;

            IList<Componente> flia = null;
            if (init)
            {
                //Para traerme las familias
                flia = BLPermiso.GetAll("=" + seleccion.Id);


                foreach (var i in flia)
                    seleccion.AgregarHijo(i);
            }
            else
            {
                flia = seleccion.Hijos;
            }

            this.treeConfigFamilia.Nodes.Clear();

            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            this.treeConfigFamilia.Nodes.Add(root);

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }

            treeConfigFamilia.ExpandAll();
        }
        void MostrarEnTreeView(TreeNode tn, Componente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {
                    MostrarEnTreeView(n, item);
                }

        }

        private bool validarRecursividad(Familia familia, Familia padre)
        {
            BLPermiso.FillFamilyComponents(familia);
            return auxValidarRecursividad(familia, padre);
        }
        private bool auxValidarRecursividad(Familia familia, Familia padre)
        {
            foreach (var item in familia.Hijos)
            {
                if (item.Id == padre.Id)
                {
                    return false;
                }
                if (item is Familia childFamilia)
                {
                    if (!auxValidarRecursividad(childFamilia, padre))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cboFamilias.SelectedItem;
            seleccion = new Familia();
            seleccion.Id = tmp.Id;
            seleccion.Nombre = tmp.Nombre;

            MostrarFamilia(true);
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                var familia = (Familia)cboFamilias.SelectedItem;
                if (familia != null)
                {
                    if (validarRecursividad(familia, seleccion))
                    {
                        var esta = BLPermiso.Existe(seleccion, familia.Id);
                        if (esta)
                            MessageBox.Show("ya exsite la familia indicada");
                        else
                        {
                            BLPermiso.FillFamilyComponents(familia);
                            seleccion.AgregarHijo(familia);
                            MostrarFamilia(false);
                        }
                    }
                    else
                    {
                        MessageBox.Show("problemas de recursividad");
                    }
                }
            }
        }

        private void btnGuardarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                BLPermiso.GuardarFamilia(seleccion);
                MessageBox.Show("Familia guardada correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al guardar la familia");
            }
        }

        private void btnGuardarSimple_Click(object sender, EventArgs e)
        {
            Familia p = new Familia()
            {
                Nombre = this.txtNombreFamlia.Text
            };
            BLPermiso.GuardarComponente(p, true);
            LlenarPatentesFamilias();
            MessageBox.Show("Familia guardada correctamente");
        }

        private void btnGuardarPatente_Click(object sender, EventArgs e)
        {
            Patente p = new Patente()
            {
                Nombre = this.txtNombrePatente.Text,
                Permiso = (TipoPermiso)this.cboPermisos.SelectedItem

            };

            BLPermiso.GuardarComponente(p, false);
            LlenarPatentesFamilias();

            MessageBox.Show("Patente guardada correctamente");
        }

        private void treeConfigFamilia_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
