namespace UI.Canchas
{
    partial class ModificacionCanchas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtCambioNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevaDescrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.btnNuevoPrecio = new System.Windows.Forms.Button();
            this.btnNuevaDescrip = new System.Windows.Forms.Button();
            this.btnCambioNombre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(135, 447);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(91, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtCambioNombre
            // 
            this.txtCambioNombre.Location = new System.Drawing.Point(83, 58);
            this.txtCambioNombre.Name = "txtCambioNombre";
            this.txtCambioNombre.Size = new System.Drawing.Size(196, 22);
            this.txtCambioNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese el nuevo nombre de la cancha seleccionada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese la nueva descripción de la cancha seleccionada";
            // 
            // txtNuevaDescrip
            // 
            this.txtNuevaDescrip.Location = new System.Drawing.Point(29, 202);
            this.txtNuevaDescrip.Name = "txtNuevaDescrip";
            this.txtNuevaDescrip.Size = new System.Drawing.Size(341, 22);
            this.txtNuevaDescrip.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese el nuevo precio de la cancha seleccionada";
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(94, 345);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(175, 22);
            this.txtNuevoPrecio.TabIndex = 7;
            // 
            // btnNuevoPrecio
            // 
            this.btnNuevoPrecio.Location = new System.Drawing.Point(126, 230);
            this.btnNuevoPrecio.Name = "btnNuevoPrecio";
            this.btnNuevoPrecio.Size = new System.Drawing.Size(120, 29);
            this.btnNuevoPrecio.TabIndex = 8;
            this.btnNuevoPrecio.Tag = "btnGuardarCambios";
            this.btnNuevoPrecio.Text = "Guardar";
            this.btnNuevoPrecio.UseVisualStyleBackColor = true;
            this.btnNuevoPrecio.Click += new System.EventHandler(this.btnNuevoPrecio_Click);
            // 
            // btnNuevaDescrip
            // 
            this.btnNuevaDescrip.Location = new System.Drawing.Point(126, 86);
            this.btnNuevaDescrip.Name = "btnNuevaDescrip";
            this.btnNuevaDescrip.Size = new System.Drawing.Size(120, 29);
            this.btnNuevaDescrip.TabIndex = 9;
            this.btnNuevaDescrip.Tag = "btnGuardarCambios";
            this.btnNuevaDescrip.Text = "Guardar";
            this.btnNuevaDescrip.UseVisualStyleBackColor = true;
            this.btnNuevaDescrip.Click += new System.EventHandler(this.btnNuevaDescrip_Click);
            // 
            // btnCambioNombre
            // 
            this.btnCambioNombre.Location = new System.Drawing.Point(126, 373);
            this.btnCambioNombre.Name = "btnCambioNombre";
            this.btnCambioNombre.Size = new System.Drawing.Size(120, 29);
            this.btnCambioNombre.TabIndex = 10;
            this.btnCambioNombre.Tag = "btnGuardarCambios";
            this.btnCambioNombre.Text = "Guardar";
            this.btnCambioNombre.UseVisualStyleBackColor = true;
            this.btnCambioNombre.Click += new System.EventHandler(this.btnCambioNombre_Click);
            // 
            // ModificacionCanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1441, 491);
            this.Controls.Add(this.btnCambioNombre);
            this.Controls.Add(this.btnNuevaDescrip);
            this.Controls.Add(this.btnNuevoPrecio);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNuevaDescrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCambioNombre);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ModificacionCanchas";
            this.Text = "ModificacionCanchas";
            this.Load += new System.EventHandler(this.ModificacionCanchas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtCambioNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevaDescrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.Button btnNuevoPrecio;
        private System.Windows.Forms.Button btnNuevaDescrip;
        private System.Windows.Forms.Button btnCambioNombre;
    }
}