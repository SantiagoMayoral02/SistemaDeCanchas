using BE;
using BL;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UI.Canchas;

namespace UI
{
    public partial class Admin : Form
    {
        private Form1 form1;
        private Dictionary<ToolStripMenuItem, string[]> permisosMenu;
        BLBitacora bitacora = new BLBitacora(); 
        public Admin(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Ingreso a la pantalla admin");
            lblUsu.Text = BLSessionManager.GetInstance.Usuario.Nombre;

            labelRol.Text = string.Join(", ", BLSessionManager.GetInstance.Usuario.Permisos.Select(p => p.Permiso));

            bitacora.comprobarRegistros();
            CargarRoles(BLSessionManager.GetInstance.Usuario);
        }
        private void CargarRoles(Usuario usuario)
        {
            InicializarPermisosMenu();

            foreach (var entrada in permisosMenu)
            {
                var menuItem = entrada.Key;
                var permisosRequeridos = entrada.Value;

                bool habilitar = permisosRequeridos.Any(p => PermisoHelper.UsuarioTienePermiso(usuario, p));
                menuItem.Enabled = habilitar;
            }
        }
        private void InicializarPermisosMenu()
        {
            permisosMenu = new Dictionary<ToolStripMenuItem, string[]>
            {
                { formularioDeReservasToolStripMenuItem, new[] { "PuedeReservar", "PuedeConfirmarPagos" } },
                { idiomasToolStripMenuItem,             new[] { "PuedeHacerTodo" } },
                { gestionesToolStripMenuItem,           new[] { "PuedeHacerTodo" } },
                { backupToolStripMenuItem,              new[] { "PuedeHacerTodo" } },
                { bitacoraToolStripMenuItem,            new[] { "PuedeHacerTodo" } },
                { canchasToolStripMenuItem,            new[] { "PuedeHacerTodo" } },
                { mantenimientoToolStripMenuItem,       new[] { "PuedeConfigurarMantenimiento" } },
                {confirmarReservasToolStripMenuItem,    new[] { "PuedeConfirmarPagos" } }
            };
        }
        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            bitacora.InsertarBitacora((BLSessionManager.GetInstance).Usuario, "Desconexión de usuario");
            BLSessionManager.logaut();
            MessageBox.Show("Sesión desconectada correctamente");
            form1.Show();
            this.Close();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro(this);
            formRegistro.Show();
            this.Hide();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificacionUsuarios modiForm = new ModificacionUsuarios(this);
            modiForm.Show();
            this.Hide();
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora bitacora = new Bitacora(this);
            bitacora.Show();
            this.Hide();
        }

        private void rolesYPermisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPatentesFamilias familiaPatenteForm = new FormPatentesFamilias(this);
            familiaPatenteForm.Show();
            this.Hide();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rolesUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionUsuario gestionUsuarioForm = new FormGestionUsuario(this);
            gestionUsuarioForm.Show();
            this.Hide();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraducciones formTraducciones = new FormTraducciones(this);
            formTraducciones.Show();
            this.Hide();
        }

        private void crearNuevaCanchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearCancha formCrearCancha = new FormCrearCancha(this);
            formCrearCancha.Show();
            this.Hide();
        }

        private void añadirTraduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTraducciones formTraducciones = new FormTraducciones(this);
            formTraducciones.Show();
            this.Hide();
        }

        private void horariosReservadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListadoReservas formReservas = new frmListadoReservas(this);
            formReservas.Show();    
            this.Hide();
        }

        private void formularioDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReservarCancha reservasForm = new frmReservarCancha(this);
            reservasForm.Show();
            this.Hide();
        }

        private void idiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMantenimientoCanchas mantenimientoCanchas = new FormMantenimientoCanchas(this);
            mantenimientoCanchas.Show();
            this.Hide();
        }

        private void confirmarReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarPago formRegistrarPago = new FormRegistrarPago(this);
            formRegistrarPago.Show();
            this.Hide();
        }

        private void crearNuevaCanchaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCrearCancha formCrearCancha = new FormCrearCancha(this);
            formCrearCancha.Show();
            this.Hide();
        }

        private void canchasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administrarCanchasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificacionCanchas formModifCanchas = new ModificacionCanchas(this);
            formModifCanchas.Show();
            this.Hide();
        }
    }
}
