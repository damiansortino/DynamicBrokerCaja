
namespace DynamicBrokerCaja.Views
{
    partial class ConfigInterParana
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
            this.btnSeleccionarCarpeta = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbCarpeta = new System.Windows.Forms.TextBox();
            this.fbd_BuscarCarpeta = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(12, 38);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(146, 23);
            this.btnSeleccionarCarpeta.TabIndex = 0;
            this.btnSeleccionarCarpeta.Text = "Seleccionar carpeta ...";
            this.btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(209, 129);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(528, 129);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbCarpeta
            // 
            this.tbCarpeta.Location = new System.Drawing.Point(195, 41);
            this.tbCarpeta.Name = "tbCarpeta";
            this.tbCarpeta.Size = new System.Drawing.Size(448, 20);
            this.tbCarpeta.TabIndex = 3;
            // 
            // ConfigInterParana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 178);
            this.Controls.Add(this.tbCarpeta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Name = "ConfigInterParana";
            this.Text = "ConfigInterParana";
            this.Load += new System.EventHandler(this.ConfigInterParana_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionarCarpeta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbCarpeta;
        private System.Windows.Forms.FolderBrowserDialog fbd_BuscarCarpeta;
    }
}