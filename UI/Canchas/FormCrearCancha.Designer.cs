namespace UI
{
    partial class FormCrearCancha
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
            this.txtNombreNuevaCancha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionCancha = new System.Windows.Forms.TextBox();
            this.btnConfirmTipo = new System.Windows.Forms.Button();
            this.btnConfirmCancha = new System.Windows.Forms.Button();
            this.cmbTipoCancha = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNuevoTipoCancha = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el nombre de la nueva cancha";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNombreNuevaCancha
            // 
            this.txtNombreNuevaCancha.Location = new System.Drawing.Point(47, 103);
            this.txtNombreNuevaCancha.Name = "txtNombreNuevaCancha";
            this.txtNombreNuevaCancha.Size = new System.Drawing.Size(232, 22);
            this.txtNombreNuevaCancha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese una descripción para la cancha";
            // 
            // txtDescripcionCancha
            // 
            this.txtDescripcionCancha.Location = new System.Drawing.Point(47, 181);
            this.txtDescripcionCancha.Name = "txtDescripcionCancha";
            this.txtDescripcionCancha.Size = new System.Drawing.Size(232, 22);
            this.txtDescripcionCancha.TabIndex = 3;
            // 
            // btnConfirmTipo
            // 
            this.btnConfirmTipo.Location = new System.Drawing.Point(493, 201);
            this.btnConfirmTipo.Name = "btnConfirmTipo";
            this.btnConfirmTipo.Size = new System.Drawing.Size(232, 49);
            this.btnConfirmTipo.TabIndex = 4;
            this.btnConfirmTipo.Text = "Confirmar";
            this.btnConfirmTipo.UseVisualStyleBackColor = true;
            this.btnConfirmTipo.Click += new System.EventHandler(this.btnConfirmTipo_Click);
            // 
            // btnConfirmCancha
            // 
            this.btnConfirmCancha.Location = new System.Drawing.Point(40, 377);
            this.btnConfirmCancha.Name = "btnConfirmCancha";
            this.btnConfirmCancha.Size = new System.Drawing.Size(239, 51);
            this.btnConfirmCancha.TabIndex = 5;
            this.btnConfirmCancha.Text = "Confirmar";
            this.btnConfirmCancha.UseVisualStyleBackColor = true;
            this.btnConfirmCancha.Click += new System.EventHandler(this.btnConfirmCancha_Click);
            // 
            // cmbTipoCancha
            // 
            this.cmbTipoCancha.FormattingEnabled = true;
            this.cmbTipoCancha.Location = new System.Drawing.Point(40, 250);
            this.cmbTipoCancha.Name = "cmbTipoCancha";
            this.cmbTipoCancha.Size = new System.Drawing.Size(239, 24);
            this.cmbTipoCancha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione el tipo de cancha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ingrese el nombre del nuevo tipo de cancha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Creación de canchas de los deportes que se practican";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "(En caso de que requiera)";
            // 
            // txtNuevoTipoCancha
            // 
            this.txtNuevoTipoCancha.Location = new System.Drawing.Point(475, 150);
            this.txtNuevoTipoCancha.Name = "txtNuevoTipoCancha";
            this.txtNuevoTipoCancha.Size = new System.Drawing.Size(265, 22);
            this.txtNuevoTipoCancha.TabIndex = 11;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(605, 381);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(164, 42);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(98, 326);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(127, 22);
            this.txtPrecio.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ingrese el valor de la cancha";
            // 
            // FormCrearCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.txtNuevoTipoCancha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoCancha);
            this.Controls.Add(this.btnConfirmCancha);
            this.Controls.Add(this.btnConfirmTipo);
            this.Controls.Add(this.txtDescripcionCancha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreNuevaCancha);
            this.Controls.Add(this.label1);
            this.Name = "FormCrearCancha";
            this.Text = "FormCrearCancha";
            this.Load += new System.EventHandler(this.FormCrearCancha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreNuevaCancha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionCancha;
        private System.Windows.Forms.Button btnConfirmTipo;
        private System.Windows.Forms.Button btnConfirmCancha;
        private System.Windows.Forms.ComboBox cmbTipoCancha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuevoTipoCancha;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
    }
}