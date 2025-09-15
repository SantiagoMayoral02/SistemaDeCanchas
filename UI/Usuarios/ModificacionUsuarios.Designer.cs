namespace UI
{
    partial class ModificacionUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUsu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNombre = new System.Windows.Forms.Button();
            this.btnContra = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnDesbloqueo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Administrador";
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Location = new System.Drawing.Point(80, 18);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(83, 16);
            this.lblUsu.TabIndex = 2;
            this.lblUsu.Text = "Nombre Usu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(276, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 389);
            this.dataGridView1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seleccione el usuario a modificar";
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(15, 143);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(230, 57);
            this.btnNombre.TabIndex = 6;
            this.btnNombre.Text = "Cambiar nombre del usuario seleccionado";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // btnContra
            // 
            this.btnContra.Location = new System.Drawing.Point(12, 247);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(233, 57);
            this.btnContra.TabIndex = 7;
            this.btnContra.Text = "Cambiar contraseña del usuario seleccionado";
            this.btnContra.UseVisualStyleBackColor = true;
            this.btnContra.Click += new System.EventHandler(this.btnContra_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 386);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(233, 36);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(15, 115);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(230, 22);
            this.txtNom.TabIndex = 9;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(12, 219);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(233, 22);
            this.txtContra.TabIndex = 10;
            // 
            // btnDesbloqueo
            // 
            this.btnDesbloqueo.Location = new System.Drawing.Point(12, 334);
            this.btnDesbloqueo.Name = "btnDesbloqueo";
            this.btnDesbloqueo.Size = new System.Drawing.Size(233, 35);
            this.btnDesbloqueo.TabIndex = 11;
            this.btnDesbloqueo.Text = "Desbloquear usuario seleccionado";
            this.btnDesbloqueo.UseVisualStyleBackColor = true;
            this.btnDesbloqueo.Click += new System.EventHandler(this.btnDesbloqueo_Click);
            // 
            // ModificacionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDesbloqueo);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnContra);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionUsuarios";
            this.Text = "ModificacionUsuarios";
            this.Load += new System.EventHandler(this.ModificacionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.Button btnContra;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnDesbloqueo;
    }
}