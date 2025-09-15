namespace UI
{
    partial class FormRegistrarPago
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
            this.dgvReservasPendientes = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblInfoPago = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservasPendientes
            // 
            this.dgvReservasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservasPendientes.Location = new System.Drawing.Point(12, 159);
            this.dgvReservasPendientes.Name = "dgvReservasPendientes";
            this.dgvReservasPendientes.RowHeadersWidth = 51;
            this.dgvReservasPendientes.RowTemplate.Height = 24;
            this.dgvReservasPendientes.Size = new System.Drawing.Size(1184, 440);
            this.dgvReservasPendientes.TabIndex = 0;
            this.dgvReservasPendientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservasPendientes_CellContentClick);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(689, 43);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(147, 58);
            this.btnConfirmar.TabIndex = 1;
            this.btnConfirmar.Text = "Confirmar Reserva";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(88, 77);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(276, 24);
            this.cmbMetodoPago.TabIndex = 2;
            // 
            // lblInfoPago
            // 
            this.lblInfoPago.AutoSize = true;
            this.lblInfoPago.Location = new System.Drawing.Point(38, 43);
            this.lblInfoPago.Name = "lblInfoPago";
            this.lblInfoPago.Size = new System.Drawing.Size(417, 16);
            this.lblInfoPago.TabIndex = 3;
            this.lblInfoPago.Text = "Seleccione la reserva y el método de pago para confirmar la reserva";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1025, 43);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(147, 58);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormRegistrarPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1211, 611);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblInfoPago);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dgvReservasPendientes);
            this.Name = "FormRegistrarPago";
            this.Text = "FormRegistrarPago";
            this.Load += new System.EventHandler(this.FormRegistrarPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservasPendientes;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label lblInfoPago;
        private System.Windows.Forms.Button btnVolver;
    }
}