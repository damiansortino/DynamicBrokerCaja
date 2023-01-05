
namespace DynamicBrokerCaja.Views
{
    partial class CerrarCajaView
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
            this.tbImporteCierre = new System.Windows.Forms.TextBox();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDiferenciaCaja = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el importe de efectivo en caja";
            // 
            // tbImporteCierre
            // 
            this.tbImporteCierre.Location = new System.Drawing.Point(226, 43);
            this.tbImporteCierre.Name = "tbImporteCierre";
            this.tbImporteCierre.Size = new System.Drawing.Size(164, 20);
            this.tbImporteCierre.TabIndex = 1;
            this.tbImporteCierre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbImporteCierre_MouseClick);
            this.tbImporteCierre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbImporteCierre_KeyPress);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(148, 153);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarCaja.TabIndex = 2;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Visible = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(315, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDiferenciaCaja
            // 
            this.lblDiferenciaCaja.AutoSize = true;
            this.lblDiferenciaCaja.Location = new System.Drawing.Point(93, 90);
            this.lblDiferenciaCaja.Name = "lblDiferenciaCaja";
            this.lblDiferenciaCaja.Size = new System.Drawing.Size(94, 13);
            this.lblDiferenciaCaja.TabIndex = 4;
            this.lblDiferenciaCaja.Text = "Diferencia de Caja";
            this.lblDiferenciaCaja.Visible = false;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(415, 41);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CerrarCajaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(545, 270);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblDiferenciaCaja);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.tbImporteCierre);
            this.Controls.Add(this.label1);
            this.Name = "CerrarCajaView";
            this.Text = "CerrarCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImporteCierre;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDiferenciaCaja;
        private System.Windows.Forms.Button btnOK;
    }
}