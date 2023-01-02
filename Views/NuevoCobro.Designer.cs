
namespace DynamicBrokerCaja.Views
{
    partial class NuevoCobro
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
            this.tbBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.cbMedioPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPoliza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEndoso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCuota = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRama = new System.Windows.Forms.ComboBox();
            this.gbContenedorRecibo = new System.Windows.Forms.GroupBox();
            this.lblVencimientoActual = new System.Windows.Forms.Label();
            this.dtpVencimientoRecibo = new System.Windows.Forms.DateTimePicker();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbContenedorRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbBarra
            // 
            this.tbBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBarra.Location = new System.Drawing.Point(209, 86);
            this.tbBarra.Name = "tbBarra";
            this.tbBarra.Size = new System.Drawing.Size(368, 22);
            this.tbBarra.TabIndex = 0;
            this.tbBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarra_KeyPress);
            this.tbBarra.Leave += new System.EventHandler(this.tbBarra_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de barra (Recibo)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rama";
            // 
            // tbCliente
            // 
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(209, 123);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(368, 22);
            this.tbCliente.TabIndex = 6;
            // 
            // cbMedioPago
            // 
            this.cbMedioPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedioPago.FormattingEnabled = true;
            this.cbMedioPago.Location = new System.Drawing.Point(147, 406);
            this.cbMedioPago.Name = "cbMedioPago";
            this.cbMedioPago.Size = new System.Drawing.Size(207, 24);
            this.cbMedioPago.TabIndex = 11;
            this.cbMedioPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbMedioPago_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Forma de Pago";
            // 
            // tbPoliza
            // 
            this.tbPoliza.Location = new System.Drawing.Point(202, 60);
            this.tbPoliza.Name = "tbPoliza";
            this.tbPoliza.Size = new System.Drawing.Size(140, 22);
            this.tbPoliza.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Póliza / Asociada";
            // 
            // tbEndoso
            // 
            this.tbEndoso.Location = new System.Drawing.Point(202, 93);
            this.tbEndoso.Name = "tbEndoso";
            this.tbEndoso.Size = new System.Drawing.Size(97, 22);
            this.tbEndoso.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Endoso";
            // 
            // tbImporte
            // 
            this.tbImporte.Location = new System.Drawing.Point(202, 125);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(140, 22);
            this.tbImporte.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Importe";
            // 
            // tbCuota
            // 
            this.tbCuota.Location = new System.Drawing.Point(203, 156);
            this.tbCuota.Name = "tbCuota";
            this.tbCuota.Size = new System.Drawing.Size(97, 22);
            this.tbCuota.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Cuota";
            // 
            // cbRama
            // 
            this.cbRama.FormattingEnabled = true;
            this.cbRama.Location = new System.Drawing.Point(202, 25);
            this.cbRama.Name = "cbRama";
            this.cbRama.Size = new System.Drawing.Size(201, 24);
            this.cbRama.TabIndex = 20;
            // 
            // gbContenedorRecibo
            // 
            this.gbContenedorRecibo.Controls.Add(this.lblVencimientoActual);
            this.gbContenedorRecibo.Controls.Add(this.dtpVencimientoRecibo);
            this.gbContenedorRecibo.Controls.Add(this.label3);
            this.gbContenedorRecibo.Controls.Add(this.cbRama);
            this.gbContenedorRecibo.Controls.Add(this.label4);
            this.gbContenedorRecibo.Controls.Add(this.tbCuota);
            this.gbContenedorRecibo.Controls.Add(this.tbPoliza);
            this.gbContenedorRecibo.Controls.Add(this.label8);
            this.gbContenedorRecibo.Controls.Add(this.label5);
            this.gbContenedorRecibo.Controls.Add(this.tbImporte);
            this.gbContenedorRecibo.Controls.Add(this.tbEndoso);
            this.gbContenedorRecibo.Controls.Add(this.label7);
            this.gbContenedorRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContenedorRecibo.Location = new System.Drawing.Point(27, 160);
            this.gbContenedorRecibo.Name = "gbContenedorRecibo";
            this.gbContenedorRecibo.Size = new System.Drawing.Size(577, 221);
            this.gbContenedorRecibo.TabIndex = 21;
            this.gbContenedorRecibo.TabStop = false;
            this.gbContenedorRecibo.Text = "Datos del Recibo";
            // 
            // lblVencimientoActual
            // 
            this.lblVencimientoActual.AutoSize = true;
            this.lblVencimientoActual.ForeColor = System.Drawing.Color.Black;
            this.lblVencimientoActual.Location = new System.Drawing.Point(17, 195);
            this.lblVencimientoActual.Name = "lblVencimientoActual";
            this.lblVencimientoActual.Size = new System.Drawing.Size(130, 16);
            this.lblVencimientoActual.TabIndex = 22;
            this.lblVencimientoActual.Text = "Vencimiento (Actual)";
            // 
            // dtpVencimientoRecibo
            // 
            this.dtpVencimientoRecibo.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpVencimientoRecibo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimientoRecibo.Location = new System.Drawing.Point(202, 189);
            this.dtpVencimientoRecibo.Name = "dtpVencimientoRecibo";
            this.dtpVencimientoRecibo.Size = new System.Drawing.Size(94, 22);
            this.dtpVencimientoRecibo.TabIndex = 21;
            this.dtpVencimientoRecibo.Value = new System.DateTime(2022, 12, 24, 0, 0, 0, 0);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(493, 411);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(658, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NuevoCobro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(899, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbContenedorRecibo);
            this.Controls.Add(this.cbMedioPago);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBarra);
            this.Name = "NuevoCobro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cobro";
            this.Load += new System.EventHandler(this.NuevoCobro_Load);
            this.gbContenedorRecibo.ResumeLayout(false);
            this.gbContenedorRecibo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.ComboBox cbMedioPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPoliza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEndoso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRama;
        private System.Windows.Forms.GroupBox gbContenedorRecibo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblVencimientoActual;
        private System.Windows.Forms.DateTimePicker dtpVencimientoRecibo;
    }
}