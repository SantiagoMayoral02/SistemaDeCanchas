namespace UI
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesYPermisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GestorDeIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevaCanchaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarCanchasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularioDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horariosReservadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.confirmarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(57, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Usuario:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 86);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(31, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Rol:";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(94, 53);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(80, 16);
            this.lblUsu.TabIndex = 2;
            this.lblUsu.Text = "NombreUsu";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(94, 86);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(46, 16);
            this.labelRol.TabIndex = 3;
            this.labelRol.Text = "rolUsu";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(636, 389);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(122, 29);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Tag = "btnDesconectarse";
            this.btnLogOut.Text = "Desconectarse";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.btnLogOut);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.labelRol);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lblUsu);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lbl2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.lbl1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 450);
            this.toolStripContainer1.TabIndex = 6;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionesToolStripMenuItem,
            this.idiomasToolStripMenuItem,
            this.canchasToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.bitacoraToolStripMenuItem,
            this.backupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionesToolStripMenuItem
            // 
            this.gestionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem,
            this.modificarUsuariosToolStripMenuItem,
            this.rolesYPermisosToolStripMenuItem,
            this.rolesUsuariosToolStripMenuItem});
            this.gestionesToolStripMenuItem.Name = "gestionesToolStripMenuItem";
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.gestionesToolStripMenuItem.Text = "Gestiones Usuarios";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.crearUsuariosToolStripMenuItem.Text = "Crear Usuarios";
            this.crearUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem_Click);
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            this.modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            this.modificarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            this.modificarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuariosToolStripMenuItem_Click);
            // 
            // rolesYPermisosToolStripMenuItem
            // 
            this.rolesYPermisosToolStripMenuItem.Name = "rolesYPermisosToolStripMenuItem";
            this.rolesYPermisosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rolesYPermisosToolStripMenuItem.Text = "Familias y Patentes";
            this.rolesYPermisosToolStripMenuItem.Click += new System.EventHandler(this.rolesYPermisosToolStripMenuItem_Click);
            // 
            // rolesUsuariosToolStripMenuItem
            // 
            this.rolesUsuariosToolStripMenuItem.Name = "rolesUsuariosToolStripMenuItem";
            this.rolesUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rolesUsuariosToolStripMenuItem.Text = "Roles Usuarios";
            this.rolesUsuariosToolStripMenuItem.Click += new System.EventHandler(this.rolesUsuariosToolStripMenuItem_Click);
            // 
            // idiomasToolStripMenuItem
            // 
            this.idiomasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GestorDeIdiomaToolStripMenuItem});
            this.idiomasToolStripMenuItem.Name = "idiomasToolStripMenuItem";
            this.idiomasToolStripMenuItem.Size = new System.Drawing.Size(76, 26);
            this.idiomasToolStripMenuItem.Text = "Idiomas";
            this.idiomasToolStripMenuItem.Click += new System.EventHandler(this.idiomasToolStripMenuItem_Click);
            // 
            // GestorDeIdiomaToolStripMenuItem
            // 
            this.GestorDeIdiomaToolStripMenuItem.Name = "GestorDeIdiomaToolStripMenuItem";
            this.GestorDeIdiomaToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.GestorDeIdiomaToolStripMenuItem.Text = "Gestor de idioma";
            this.GestorDeIdiomaToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // canchasToolStripMenuItem
            // 
            this.canchasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevaCanchaToolStripMenuItem1,
            this.administrarCanchasToolStripMenuItem});
            this.canchasToolStripMenuItem.Name = "canchasToolStripMenuItem";
            this.canchasToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.canchasToolStripMenuItem.Text = "Canchas";
            this.canchasToolStripMenuItem.Click += new System.EventHandler(this.canchasToolStripMenuItem_Click);
            // 
            // crearNuevaCanchaToolStripMenuItem1
            // 
            this.crearNuevaCanchaToolStripMenuItem1.Name = "crearNuevaCanchaToolStripMenuItem1";
            this.crearNuevaCanchaToolStripMenuItem1.Size = new System.Drawing.Size(225, 26);
            this.crearNuevaCanchaToolStripMenuItem1.Text = "Crear nueva cancha";
            this.crearNuevaCanchaToolStripMenuItem1.Click += new System.EventHandler(this.crearNuevaCanchaToolStripMenuItem1_Click);
            // 
            // administrarCanchasToolStripMenuItem
            // 
            this.administrarCanchasToolStripMenuItem.Name = "administrarCanchasToolStripMenuItem";
            this.administrarCanchasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.administrarCanchasToolStripMenuItem.Text = "Administrar canchas";
            this.administrarCanchasToolStripMenuItem.Click += new System.EventHandler(this.administrarCanchasToolStripMenuItem_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularioDeReservasToolStripMenuItem,
            this.horariosReservadosToolStripMenuItem,
            this.confirmarReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // formularioDeReservasToolStripMenuItem
            // 
            this.formularioDeReservasToolStripMenuItem.Name = "formularioDeReservasToolStripMenuItem";
            this.formularioDeReservasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.formularioDeReservasToolStripMenuItem.Text = "Crear nueva Reserva";
            this.formularioDeReservasToolStripMenuItem.Click += new System.EventHandler(this.formularioDeReservasToolStripMenuItem_Click);
            // 
            // horariosReservadosToolStripMenuItem
            // 
            this.horariosReservadosToolStripMenuItem.Name = "horariosReservadosToolStripMenuItem";
            this.horariosReservadosToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.horariosReservadosToolStripMenuItem.Text = "Horarios reservados";
            this.horariosReservadosToolStripMenuItem.Click += new System.EventHandler(this.horariosReservadosToolStripMenuItem_Click);
            // 
            // confirmarReservasToolStripMenuItem
            // 
            this.confirmarReservasToolStripMenuItem.Name = "confirmarReservasToolStripMenuItem";
            this.confirmarReservasToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.confirmarReservasToolStripMenuItem.Text = "Confirmar Reservas";
            this.confirmarReservasToolStripMenuItem.Click += new System.EventHandler(this.confirmarReservasToolStripMenuItem_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            this.mantenimientoToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(71, 26);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesYPermisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GestorDeIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularioDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horariosReservadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem confirmarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canchasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearNuevaCanchaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarCanchasToolStripMenuItem;
    }
}