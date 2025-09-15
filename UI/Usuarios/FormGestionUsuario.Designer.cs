namespace UI
{
    partial class FormGestionUsuario
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
            this.groupBoxGestUsu = new System.Windows.Forms.GroupBox();
            this.btnAgregarFamilia = new System.Windows.Forms.Button();
            this.cboFamilias = new System.Windows.Forms.ComboBox();
            this.lblAgregarFamilia = new System.Windows.Forms.Label();
            this.btnAgregarPatente = new System.Windows.Forms.Button();
            this.cboPatentes = new System.Windows.Forms.ComboBox();
            this.lblAgregarPatente = new System.Windows.Forms.Label();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.cboUsuarios = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.treeConfigFamilia = new System.Windows.Forms.TreeView();
            this.lblLenguaje = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.groupBoxGestUsu.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGestUsu
            // 
            this.groupBoxGestUsu.Controls.Add(this.btnAgregarFamilia);
            this.groupBoxGestUsu.Controls.Add(this.cboFamilias);
            this.groupBoxGestUsu.Controls.Add(this.lblAgregarFamilia);
            this.groupBoxGestUsu.Controls.Add(this.btnAgregarPatente);
            this.groupBoxGestUsu.Controls.Add(this.cboPatentes);
            this.groupBoxGestUsu.Controls.Add(this.lblAgregarPatente);
            this.groupBoxGestUsu.Controls.Add(this.lblUsuarios);
            this.groupBoxGestUsu.Controls.Add(this.btnConfigurar);
            this.groupBoxGestUsu.Controls.Add(this.cboUsuarios);
            this.groupBoxGestUsu.Location = new System.Drawing.Point(35, 12);
            this.groupBoxGestUsu.Name = "groupBoxGestUsu";
            this.groupBoxGestUsu.Size = new System.Drawing.Size(247, 412);
            this.groupBoxGestUsu.TabIndex = 1;
            this.groupBoxGestUsu.TabStop = false;
            this.groupBoxGestUsu.Text = "Patentes";
            // 
            // btnAgregarFamilia
            // 
            this.btnAgregarFamilia.Location = new System.Drawing.Point(17, 346);
            this.btnAgregarFamilia.Name = "btnAgregarFamilia";
            this.btnAgregarFamilia.Size = new System.Drawing.Size(111, 32);
            this.btnAgregarFamilia.TabIndex = 13;
            this.btnAgregarFamilia.Text = "Agregar >>";
            this.btnAgregarFamilia.UseVisualStyleBackColor = true;
            this.btnAgregarFamilia.Click += new System.EventHandler(this.btnAgregarFamilia_Click);
            // 
            // cboFamilias
            // 
            this.cboFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilias.FormattingEnabled = true;
            this.cboFamilias.Location = new System.Drawing.Point(20, 316);
            this.cboFamilias.Name = "cboFamilias";
            this.cboFamilias.Size = new System.Drawing.Size(207, 24);
            this.cboFamilias.TabIndex = 12;
            // 
            // lblAgregarFamilia
            // 
            this.lblAgregarFamilia.AutoSize = true;
            this.lblAgregarFamilia.Location = new System.Drawing.Point(17, 297);
            this.lblAgregarFamilia.Name = "lblAgregarFamilia";
            this.lblAgregarFamilia.Size = new System.Drawing.Size(110, 16);
            this.lblAgregarFamilia.TabIndex = 11;
            this.lblAgregarFamilia.Text = "Agregar Familias";
            // 
            // btnAgregarPatente
            // 
            this.btnAgregarPatente.Location = new System.Drawing.Point(20, 230);
            this.btnAgregarPatente.Name = "btnAgregarPatente";
            this.btnAgregarPatente.Size = new System.Drawing.Size(111, 32);
            this.btnAgregarPatente.TabIndex = 10;
            this.btnAgregarPatente.Text = "Agregar >>";
            this.btnAgregarPatente.UseVisualStyleBackColor = true;
            this.btnAgregarPatente.Click += new System.EventHandler(this.btnAgregarPatente_Click);
            // 
            // cboPatentes
            // 
            this.cboPatentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPatentes.FormattingEnabled = true;
            this.cboPatentes.Location = new System.Drawing.Point(20, 200);
            this.cboPatentes.Name = "cboPatentes";
            this.cboPatentes.Size = new System.Drawing.Size(207, 24);
            this.cboPatentes.TabIndex = 9;
            // 
            // lblAgregarPatente
            // 
            this.lblAgregarPatente.AutoSize = true;
            this.lblAgregarPatente.Location = new System.Drawing.Point(17, 181);
            this.lblAgregarPatente.Name = "lblAgregarPatente";
            this.lblAgregarPatente.Size = new System.Drawing.Size(111, 16);
            this.lblAgregarPatente.TabIndex = 8;
            this.lblAgregarPatente.Text = "Agregar patentes";
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.Location = new System.Drawing.Point(17, 22);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(122, 16);
            this.lblUsuarios.TabIndex = 7;
            this.lblUsuarios.Text = "Todos los usuarios";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(20, 90);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(111, 39);
            this.btnConfigurar.TabIndex = 5;
            this.btnConfigurar.Text = "Configurar";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // cboUsuarios
            // 
            this.cboUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarios.FormattingEnabled = true;
            this.cboUsuarios.Location = new System.Drawing.Point(20, 51);
            this.cboUsuarios.Name = "cboUsuarios";
            this.cboUsuarios.Size = new System.Drawing.Size(207, 24);
            this.cboUsuarios.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVolver);
            this.groupBox3.Controls.Add(this.btnGuardarCambios);
            this.groupBox3.Controls.Add(this.treeConfigFamilia);
            this.groupBox3.Location = new System.Drawing.Point(357, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 412);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(197, 374);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 23);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(6, 368);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(139, 35);
            this.btnGuardarCambios.TabIndex = 8;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // treeConfigFamilia
            // 
            this.treeConfigFamilia.Location = new System.Drawing.Point(6, 12);
            this.treeConfigFamilia.Name = "treeConfigFamilia";
            this.treeConfigFamilia.Size = new System.Drawing.Size(284, 344);
            this.treeConfigFamilia.TabIndex = 0;
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.AutoSize = true;
            this.lblLenguaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenguaje.Location = new System.Drawing.Point(30, 471);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(113, 29);
            this.lblLenguaje.TabIndex = 7;
            this.lblLenguaje.Text = "Lenguaje";
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(149, 478);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 24);
            this.cmbIdioma.TabIndex = 8;
            this.cmbIdioma.SelectedIndexChanged += new System.EventHandler(this.cmbIdioma_SelectedIndexChanged);
            // 
            // FormGestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.cmbIdioma);
            this.Controls.Add(this.lblLenguaje);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxGestUsu);
            this.Name = "FormGestionUsuario";
            this.Text = "FormGestionUsuario";
            this.Load += new System.EventHandler(this.FormGestionUsuario_Load);
            this.groupBoxGestUsu.ResumeLayout(false);
            this.groupBoxGestUsu.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGestUsu;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.ComboBox cboUsuarios;
        private System.Windows.Forms.ComboBox cboPatentes;
        private System.Windows.Forms.Label lblAgregarPatente;
        private System.Windows.Forms.Label lblAgregarFamilia;
        private System.Windows.Forms.Button btnAgregarPatente;
        private System.Windows.Forms.Button btnAgregarFamilia;
        private System.Windows.Forms.ComboBox cboFamilias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.TreeView treeConfigFamilia;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblLenguaje;
        private System.Windows.Forms.ComboBox cmbIdioma;
    }
}