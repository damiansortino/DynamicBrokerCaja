
namespace DynamicBrokerCaja.Views
{
    partial class CajasAnteriores
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
            this.dgv_Cajas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cajas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cajas
            // 
            this.dgv_Cajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cajas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Cajas.Location = new System.Drawing.Point(0, 156);
            this.dgv_Cajas.MultiSelect = false;
            this.dgv_Cajas.Name = "dgv_Cajas";
            this.dgv_Cajas.ReadOnly = true;
            this.dgv_Cajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cajas.Size = new System.Drawing.Size(954, 200);
            this.dgv_Cajas.TabIndex = 0;
            // 
            // CajasAnteriores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(954, 356);
            this.Controls.Add(this.dgv_Cajas);
            this.Name = "CajasAnteriores";
            this.Text = "CajasAnteriores";
            this.Load += new System.EventHandler(this.CajasAnteriores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cajas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cajas;
    }
}