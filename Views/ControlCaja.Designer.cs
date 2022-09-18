
namespace DynamicBrokerCaja.Views
{
    partial class ControlCaja
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
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.btnNuevoCobro = new System.Windows.Forms.Button();
            this.btnIniciarCaja = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetiroCaja = new System.Windows.Forms.Button();
            this.btnOtrosMovimientos = new System.Windows.Forms.Button();
            this.lblEfectivoCaja = new System.Windows.Forms.Label();
            this.btnEditMov = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovimientos
            // 
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 158);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(800, 292);
            this.dgvMovimientos.TabIndex = 0;
            this.dgvMovimientos.Leave += new System.EventHandler(this.dgvMovimientos_Leave);
            this.dgvMovimientos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMovimientos_MouseClick);
            // 
            // btnNuevoCobro
            // 
            this.btnNuevoCobro.Location = new System.Drawing.Point(12, 68);
            this.btnNuevoCobro.Name = "btnNuevoCobro";
            this.btnNuevoCobro.Size = new System.Drawing.Size(122, 23);
            this.btnNuevoCobro.TabIndex = 1;
            this.btnNuevoCobro.Text = "Nuevo Cobro (F1)";
            this.btnNuevoCobro.UseVisualStyleBackColor = true;
            this.btnNuevoCobro.Click += new System.EventHandler(this.btnNuevoCobro_Click);
            // 
            // btnIniciarCaja
            // 
            this.btnIniciarCaja.Location = new System.Drawing.Point(159, 68);
            this.btnIniciarCaja.Name = "btnIniciarCaja";
            this.btnIniciarCaja.Size = new System.Drawing.Size(122, 23);
            this.btnIniciarCaja.TabIndex = 2;
            this.btnIniciarCaja.Text = "IniciarCaja (F2)";
            this.btnIniciarCaja.UseVisualStyleBackColor = true;
            this.btnIniciarCaja.Click += new System.EventHandler(this.btnIniciarCaja_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Location = new System.Drawing.Point(304, 68);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(122, 23);
            this.btnCerrarCaja.TabIndex = 3;
            this.btnCerrarCaja.Text = "CerrarCaja (F3)";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control de Caja";
            // 
            // btnRetiroCaja
            // 
            this.btnRetiroCaja.Location = new System.Drawing.Point(449, 68);
            this.btnRetiroCaja.Name = "btnRetiroCaja";
            this.btnRetiroCaja.Size = new System.Drawing.Size(122, 23);
            this.btnRetiroCaja.TabIndex = 6;
            this.btnRetiroCaja.Text = "Retiro de Caja (F4)";
            this.btnRetiroCaja.UseVisualStyleBackColor = true;
            this.btnRetiroCaja.Click += new System.EventHandler(this.btnRetiroCaja_Click);
            // 
            // btnOtrosMovimientos
            // 
            this.btnOtrosMovimientos.Location = new System.Drawing.Point(590, 68);
            this.btnOtrosMovimientos.Name = "btnOtrosMovimientos";
            this.btnOtrosMovimientos.Size = new System.Drawing.Size(149, 23);
            this.btnOtrosMovimientos.TabIndex = 7;
            this.btnOtrosMovimientos.Text = "Otros Movimientos (F5)";
            this.btnOtrosMovimientos.UseVisualStyleBackColor = true;
            this.btnOtrosMovimientos.Click += new System.EventHandler(this.btnOtrosMovimientos_Click);
            // 
            // lblEfectivoCaja
            // 
            this.lblEfectivoCaja.AutoSize = true;
            this.lblEfectivoCaja.Location = new System.Drawing.Point(259, 125);
            this.lblEfectivoCaja.Name = "lblEfectivoCaja";
            this.lblEfectivoCaja.Size = new System.Drawing.Size(97, 13);
            this.lblEfectivoCaja.TabIndex = 9;
            this.lblEfectivoCaja.Text = "Efectivo en Caja $ ";
            // 
            // btnEditMov
            // 
            this.btnEditMov.BackgroundImage = global::DynamicBrokerCaja.Properties.Resources.edit_icon;
            this.btnEditMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditMov.Enabled = false;
            this.btnEditMov.Location = new System.Drawing.Point(100, 110);
            this.btnEditMov.Name = "btnEditMov";
            this.btnEditMov.Size = new System.Drawing.Size(47, 42);
            this.btnEditMov.TabIndex = 10;
            this.btnEditMov.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::DynamicBrokerCaja.Properties.Resources.iconRefresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(21, 110);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 42);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ControlCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditMov);
            this.Controls.Add(this.lblEfectivoCaja);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOtrosMovimientos);
            this.Controls.Add(this.btnRetiroCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnIniciarCaja);
            this.Controls.Add(this.btnNuevoCobro);
            this.Controls.Add(this.dgvMovimientos);
            this.Name = "ControlCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMovimientos;
        private System.Windows.Forms.Button btnNuevoCobro;
        private System.Windows.Forms.Button btnIniciarCaja;
        private System.Windows.Forms.Button btnCerrarCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetiroCaja;
        private System.Windows.Forms.Button btnOtrosMovimientos;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblEfectivoCaja;
        private System.Windows.Forms.Button btnEditMov;
    }
}