namespace UI
{
    partial class frmReservarCancha
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
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblLenguaje = new System.Windows.Forms.Label();
            this.cmbTipoCancha = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbHoraInicio = new System.Windows.Forms.ComboBox();
            this.numDuracionHoras = new System.Windows.Forms.NumericUpDown();
            this.txtDNICliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblEstadoDispo = new System.Windows.Forms.Label();
            this.btnConfirmarReserva = new System.Windows.Forms.Button();
            this.cmbCanchasDisponibles = new System.Windows.Forms.ComboBox();
            this.lblCanchasDispo = new System.Windows.Forms.Label();
            this.lblTipoCancha = new System.Windows.Forms.Label();
            this.lblDiaReserva = new System.Windows.Forms.Label();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.lblHorasAReservar = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.labelNombreCliente = new System.Windows.Forms.Label();
            this.rbtnEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtnMPago = new System.Windows.Forms.RadioButton();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.btnVerReservas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIdioma
            // 
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(153, 576);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(121, 24);
            this.cmbIdioma.TabIndex = 8;
            // 
            // lblLenguaje
            // 
            this.lblLenguaje.AutoSize = true;
            this.lblLenguaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenguaje.Location = new System.Drawing.Point(12, 569);
            this.lblLenguaje.Name = "lblLenguaje";
            this.lblLenguaje.Size = new System.Drawing.Size(113, 29);
            this.lblLenguaje.TabIndex = 12;
            this.lblLenguaje.Text = "Lenguaje";
            // 
            // cmbTipoCancha
            // 
            this.cmbTipoCancha.FormattingEnabled = true;
            this.cmbTipoCancha.Location = new System.Drawing.Point(20, 139);
            this.cmbTipoCancha.Name = "cmbTipoCancha";
            this.cmbTipoCancha.Size = new System.Drawing.Size(121, 24);
            this.cmbTipoCancha.TabIndex = 13;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(20, 247);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(256, 22);
            this.dtpFecha.TabIndex = 14;
            // 
            // cmbHoraInicio
            // 
            this.cmbHoraInicio.FormattingEnabled = true;
            this.cmbHoraInicio.Location = new System.Drawing.Point(390, 246);
            this.cmbHoraInicio.Name = "cmbHoraInicio";
            this.cmbHoraInicio.Size = new System.Drawing.Size(203, 24);
            this.cmbHoraInicio.TabIndex = 15;
            // 
            // numDuracionHoras
            // 
            this.numDuracionHoras.Location = new System.Drawing.Point(819, 246);
            this.numDuracionHoras.Name = "numDuracionHoras";
            this.numDuracionHoras.Size = new System.Drawing.Size(120, 22);
            this.numDuracionHoras.TabIndex = 16;
            // 
            // txtDNICliente
            // 
            this.txtDNICliente.Location = new System.Drawing.Point(20, 45);
            this.txtDNICliente.Name = "txtDNICliente";
            this.txtDNICliente.Size = new System.Drawing.Size(254, 22);
            this.txtDNICliente.TabIndex = 18;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(333, 42);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(124, 29);
            this.btnBuscarCliente.TabIndex = 19;
            this.btnBuscarCliente.Text = "Buscar cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click_1);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCliente.Location = new System.Drawing.Point(17, 9);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(60, 18);
            this.lblNombreCliente.TabIndex = 20;
            this.lblNombreCliente.Text = "Cliente";
            // 
            // lblEstadoDispo
            // 
            this.lblEstadoDispo.AutoSize = true;
            this.lblEstadoDispo.Location = new System.Drawing.Point(945, 343);
            this.lblEstadoDispo.Name = "lblEstadoDispo";
            this.lblEstadoDispo.Size = new System.Drawing.Size(50, 16);
            this.lblEstadoDispo.TabIndex = 21;
            this.lblEstadoDispo.Text = "Estado";
            // 
            // btnConfirmarReserva
            // 
            this.btnConfirmarReserva.Location = new System.Drawing.Point(759, 517);
            this.btnConfirmarReserva.Name = "btnConfirmarReserva";
            this.btnConfirmarReserva.Size = new System.Drawing.Size(218, 87);
            this.btnConfirmarReserva.TabIndex = 22;
            this.btnConfirmarReserva.Text = "Confirmar Reserva";
            this.btnConfirmarReserva.UseVisualStyleBackColor = true;
            this.btnConfirmarReserva.Click += new System.EventHandler(this.btnConfirmarReserva_Click_1);
            // 
            // cmbCanchasDisponibles
            // 
            this.cmbCanchasDisponibles.FormattingEnabled = true;
            this.cmbCanchasDisponibles.Location = new System.Drawing.Point(535, 392);
            this.cmbCanchasDisponibles.Name = "cmbCanchasDisponibles";
            this.cmbCanchasDisponibles.Size = new System.Drawing.Size(223, 24);
            this.cmbCanchasDisponibles.TabIndex = 23;
            // 
            // lblCanchasDispo
            // 
            this.lblCanchasDispo.AutoSize = true;
            this.lblCanchasDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCanchasDispo.Location = new System.Drawing.Point(504, 343);
            this.lblCanchasDispo.Name = "lblCanchasDispo";
            this.lblCanchasDispo.Size = new System.Drawing.Size(293, 18);
            this.lblCanchasDispo.TabIndex = 24;
            this.lblCanchasDispo.Text = "Canchas disponibles para ese horario";
            // 
            // lblTipoCancha
            // 
            this.lblTipoCancha.AutoSize = true;
            this.lblTipoCancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTipoCancha.Location = new System.Drawing.Point(17, 103);
            this.lblTipoCancha.Name = "lblTipoCancha";
            this.lblTipoCancha.Size = new System.Drawing.Size(305, 18);
            this.lblTipoCancha.TabIndex = 25;
            this.lblTipoCancha.Text = "Selecciona el tipo de cancha a reservar";
            // 
            // lblDiaReserva
            // 
            this.lblDiaReserva.AutoSize = true;
            this.lblDiaReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiaReserva.Location = new System.Drawing.Point(17, 199);
            this.lblDiaReserva.Name = "lblDiaReserva";
            this.lblDiaReserva.Size = new System.Drawing.Size(171, 18);
            this.lblDiaReserva.TabIndex = 26;
            this.lblDiaReserva.Text = "Ingrese día a reservar";
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoraInicio.Location = new System.Drawing.Point(387, 199);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(224, 18);
            this.lblHoraInicio.TabIndex = 27;
            this.lblHoraInicio.Text = "Seleccionar horario de inicio";
            // 
            // lblHorasAReservar
            // 
            this.lblHorasAReservar.AutoSize = true;
            this.lblHorasAReservar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblHorasAReservar.Location = new System.Drawing.Point(718, 199);
            this.lblHorasAReservar.Name = "lblHorasAReservar";
            this.lblHorasAReservar.Size = new System.Drawing.Size(317, 18);
            this.lblHorasAReservar.TabIndex = 28;
            this.lblHorasAReservar.Text = "Seleccionar cantidad de horas a reservar";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1022, 534);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(152, 53);
            this.btnVolver.TabIndex = 29;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMetodoPago.Location = new System.Drawing.Point(12, 343);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(338, 18);
            this.lblMetodoPago.TabIndex = 31;
            this.lblMetodoPago.Text = "Seleccione el método de pago de la reserva";
            // 
            // labelNombreCliente
            // 
            this.labelNombreCliente.AutoSize = true;
            this.labelNombreCliente.Location = new System.Drawing.Point(549, 51);
            this.labelNombreCliente.Name = "labelNombreCliente";
            this.labelNombreCliente.Size = new System.Drawing.Size(0, 16);
            this.labelNombreCliente.TabIndex = 32;
            // 
            // rbtnEfectivo
            // 
            this.rbtnEfectivo.AutoSize = true;
            this.rbtnEfectivo.Location = new System.Drawing.Point(49, 396);
            this.rbtnEfectivo.Name = "rbtnEfectivo";
            this.rbtnEfectivo.Size = new System.Drawing.Size(76, 20);
            this.rbtnEfectivo.TabIndex = 33;
            this.rbtnEfectivo.TabStop = true;
            this.rbtnEfectivo.Text = "Efectivo";
            this.rbtnEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbtnMPago
            // 
            this.rbtnMPago.AutoSize = true;
            this.rbtnMPago.Location = new System.Drawing.Point(189, 396);
            this.rbtnMPago.Name = "rbtnMPago";
            this.rbtnMPago.Size = new System.Drawing.Size(118, 20);
            this.rbtnMPago.TabIndex = 34;
            this.rbtnMPago.TabStop = true;
            this.rbtnMPago.Text = "Mercado Pago";
            this.rbtnMPago.UseVisualStyleBackColor = true;
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecioFinal.Location = new System.Drawing.Point(782, 466);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(0, 18);
            this.lblPrecioFinal.TabIndex = 36;
            // 
            // btnVerReservas
            // 
            this.btnVerReservas.Location = new System.Drawing.Point(366, 534);
            this.btnVerReservas.Name = "btnVerReservas";
            this.btnVerReservas.Size = new System.Drawing.Size(155, 55);
            this.btnVerReservas.TabIndex = 37;
            this.btnVerReservas.Text = "Ver Reservas";
            this.btnVerReservas.UseVisualStyleBackColor = true;
            this.btnVerReservas.Click += new System.EventHandler(this.btnVerReservas_Click);
            // 
            // frmReservarCancha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1200, 625);
            this.Controls.Add(this.btnVerReservas);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.rbtnMPago);
            this.Controls.Add(this.rbtnEfectivo);
            this.Controls.Add(this.labelNombreCliente);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblHorasAReservar);
            this.Controls.Add(this.lblHoraInicio);
            this.Controls.Add(this.lblDiaReserva);
            this.Controls.Add(this.lblTipoCancha);
            this.Controls.Add(this.lblCanchasDispo);
            this.Controls.Add(this.cmbCanchasDisponibles);
            this.Controls.Add(this.btnConfirmarReserva);
            this.Controls.Add(this.lblEstadoDispo);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.txtDNICliente);
            this.Controls.Add(this.numDuracionHoras);
            this.Controls.Add(this.cmbHoraInicio);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbTipoCancha);
            this.Controls.Add(this.lblLenguaje);
            this.Controls.Add(this.cmbIdioma);
            this.Name = "frmReservarCancha";
            this.Text = "frmReservarCancha";
            this.Load += new System.EventHandler(this.frmReservarCancha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDuracionHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIdioma;
        private System.Windows.Forms.Label lblLenguaje;
        private System.Windows.Forms.ComboBox cmbTipoCancha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbHoraInicio;
        private System.Windows.Forms.NumericUpDown numDuracionHoras;
        private System.Windows.Forms.TextBox txtDNICliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblEstadoDispo;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.ComboBox cmbCanchasDisponibles;
        private System.Windows.Forms.Label lblCanchasDispo;
        private System.Windows.Forms.Label lblTipoCancha;
        private System.Windows.Forms.Label lblDiaReserva;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Label lblHorasAReservar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label labelNombreCliente;
        private System.Windows.Forms.RadioButton rbtnEfectivo;
        private System.Windows.Forms.RadioButton rbtnMPago;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Button btnVerReservas;
    }
}