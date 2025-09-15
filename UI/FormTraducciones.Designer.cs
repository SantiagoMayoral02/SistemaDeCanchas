namespace UI
{
    partial class FormTraducciones
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
            this.txtNuevoIdioma = new System.Windows.Forms.TextBox();
            this.btnAgregarIdioma = new System.Windows.Forms.Button();
            this.cmbIdiomasExistentes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTraduccionPorIdioma = new System.Windows.Forms.TextBox();
            this.btnGuardarTraduccion = new System.Windows.Forms.Button();
            this.lstEtiquetasFaltantes = new System.Windows.Forms.ListBox();
            this.dgvTraducciones = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listEtiquetas = new System.Windows.Forms.ListBox();
            this.lblEti = new System.Windows.Forms.Label();
            this.lblidiom = new System.Windows.Forms.Label();
            this.lbltraduc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNuevoIdioma
            // 
            this.txtNuevoIdioma.Location = new System.Drawing.Point(49, 35);
            this.txtNuevoIdioma.Name = "txtNuevoIdioma";
            this.txtNuevoIdioma.Size = new System.Drawing.Size(118, 22);
            this.txtNuevoIdioma.TabIndex = 0;
            // 
            // btnAgregarIdioma
            // 
            this.btnAgregarIdioma.Location = new System.Drawing.Point(49, 76);
            this.btnAgregarIdioma.Name = "btnAgregarIdioma";
            this.btnAgregarIdioma.Size = new System.Drawing.Size(118, 40);
            this.btnAgregarIdioma.TabIndex = 2;
            this.btnAgregarIdioma.Text = "Agregar Idioma";
            this.btnAgregarIdioma.UseVisualStyleBackColor = true;
            this.btnAgregarIdioma.Click += new System.EventHandler(this.btnAgregarIdioma_Click);
            // 
            // cmbIdiomasExistentes
            // 
            this.cmbIdiomasExistentes.FormattingEnabled = true;
            this.cmbIdiomasExistentes.Location = new System.Drawing.Point(262, 76);
            this.cmbIdiomasExistentes.Name = "cmbIdiomasExistentes";
            this.cmbIdiomasExistentes.Size = new System.Drawing.Size(121, 24);
            this.cmbIdiomasExistentes.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Etiqueta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTraduccionPorIdioma
            // 
            this.txtTraduccionPorIdioma.Location = new System.Drawing.Point(436, 78);
            this.txtTraduccionPorIdioma.Name = "txtTraduccionPorIdioma";
            this.txtTraduccionPorIdioma.Size = new System.Drawing.Size(118, 22);
            this.txtTraduccionPorIdioma.TabIndex = 6;
            // 
            // btnGuardarTraduccion
            // 
            this.btnGuardarTraduccion.Location = new System.Drawing.Point(358, 485);
            this.btnGuardarTraduccion.Name = "btnGuardarTraduccion";
            this.btnGuardarTraduccion.Size = new System.Drawing.Size(126, 55);
            this.btnGuardarTraduccion.TabIndex = 7;
            this.btnGuardarTraduccion.Text = "Guardar Traduccion";
            this.btnGuardarTraduccion.UseVisualStyleBackColor = true;
            this.btnGuardarTraduccion.Click += new System.EventHandler(this.btnGuardarTraduccion_Click);
            // 
            // lstEtiquetasFaltantes
            // 
            this.lstEtiquetasFaltantes.FormattingEnabled = true;
            this.lstEtiquetasFaltantes.ItemHeight = 16;
            this.lstEtiquetasFaltantes.Location = new System.Drawing.Point(15, 169);
            this.lstEtiquetasFaltantes.Name = "lstEtiquetasFaltantes";
            this.lstEtiquetasFaltantes.Size = new System.Drawing.Size(201, 292);
            this.lstEtiquetasFaltantes.TabIndex = 8;
            // 
            // dgvTraducciones
            // 
            this.dgvTraducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraducciones.Location = new System.Drawing.Point(659, 25);
            this.dgvTraducciones.Name = "dgvTraducciones";
            this.dgvTraducciones.RowHeadersWidth = 51;
            this.dgvTraducciones.RowTemplate.Height = 24;
            this.dgvTraducciones.Size = new System.Drawing.Size(748, 684);
            this.dgvTraducciones.TabIndex = 9;
            this.dgvTraducciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraducciones_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(87, 652);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 41);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // listEtiquetas
            // 
            this.listEtiquetas.FormattingEnabled = true;
            this.listEtiquetas.ItemHeight = 16;
            this.listEtiquetas.Location = new System.Drawing.Point(322, 153);
            this.listEtiquetas.Name = "listEtiquetas";
            this.listEtiquetas.Size = new System.Drawing.Size(201, 308);
            this.listEtiquetas.TabIndex = 12;
            this.listEtiquetas.SelectedIndexChanged += new System.EventHandler(this.listEtiquetas_SelectedIndexChanged);
            // 
            // lblEti
            // 
            this.lblEti.AutoSize = true;
            this.lblEti.Location = new System.Drawing.Point(319, 119);
            this.lblEti.Name = "lblEti";
            this.lblEti.Size = new System.Drawing.Size(198, 16);
            this.lblEti.TabIndex = 13;
            this.lblEti.Text = "Seleccione la etiqueta a traducir";
            // 
            // lblidiom
            // 
            this.lblidiom.AutoSize = true;
            this.lblidiom.Location = new System.Drawing.Point(259, 41);
            this.lblidiom.Name = "lblidiom";
            this.lblidiom.Size = new System.Drawing.Size(133, 16);
            this.lblidiom.TabIndex = 14;
            this.lblidiom.Text = "Seleccione el idioma";
            // 
            // lbltraduc
            // 
            this.lbltraduc.AutoSize = true;
            this.lbltraduc.Location = new System.Drawing.Point(433, 41);
            this.lbltraduc.Name = "lbltraduc";
            this.lbltraduc.Size = new System.Drawing.Size(131, 16);
            this.lbltraduc.TabIndex = 15;
            this.lbltraduc.Text = "Ingrese la traduccion";
            // 
            // FormTraducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1428, 737);
            this.Controls.Add(this.lbltraduc);
            this.Controls.Add(this.lblidiom);
            this.Controls.Add(this.lblEti);
            this.Controls.Add(this.listEtiquetas);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTraducciones);
            this.Controls.Add(this.lstEtiquetasFaltantes);
            this.Controls.Add(this.btnGuardarTraduccion);
            this.Controls.Add(this.txtTraduccionPorIdioma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbIdiomasExistentes);
            this.Controls.Add(this.btnAgregarIdioma);
            this.Controls.Add(this.txtNuevoIdioma);
            this.Name = "FormTraducciones";
            this.Text = "FormTraducciones";
            this.Load += new System.EventHandler(this.FormTraducciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNuevoIdioma;
        private System.Windows.Forms.Button btnAgregarIdioma;
        private System.Windows.Forms.ComboBox cmbIdiomasExistentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTraduccionPorIdioma;
        private System.Windows.Forms.Button btnGuardarTraduccion;
        private System.Windows.Forms.ListBox lstEtiquetasFaltantes;
        private System.Windows.Forms.DataGridView dgvTraducciones;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox listEtiquetas;
        private System.Windows.Forms.Label lblEti;
        private System.Windows.Forms.Label lblidiom;
        private System.Windows.Forms.Label lbltraduc;
    }
}