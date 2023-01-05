
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMovimientos = new System.Windows.Forms.DataGridView();
            this.btnNuevoCobro = new System.Windows.Forms.Button();
            this.btnIniciarCaja = new System.Windows.Forms.Button();
            this.btnCerrarCaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetiroCaja = new System.Windows.Forms.Button();
            this.btnOtrosMovimientos = new System.Windows.Forms.Button();
            this.lblEfectivoCaja = new System.Windows.Forms.Label();
            this.btnDeleteMov = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMovimientos
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMovimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMovimientos.Location = new System.Drawing.Point(0, 173);
            this.dgvMovimientos.MultiSelect = false;
            this.dgvMovimientos.Name = "dgvMovimientos";
            this.dgvMovimientos.ReadOnly = true;
            this.dgvMovimientos.RowHeadersVisible = false;
            this.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovimientos.Size = new System.Drawing.Size(1249, 379);
            this.dgvMovimientos.TabIndex = 0;
            this.dgvMovimientos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMovimientos_MouseClick);
            // 
            // btnNuevoCobro
            // 
            this.btnNuevoCobro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCobro.Location = new System.Drawing.Point(12, 68);
            this.btnNuevoCobro.Name = "btnNuevoCobro";
            this.btnNuevoCobro.Size = new System.Drawing.Size(181, 35);
            this.btnNuevoCobro.TabIndex = 1;
            this.btnNuevoCobro.Text = "Nuevo Cobro (1)";
            this.btnNuevoCobro.UseVisualStyleBackColor = true;
            this.btnNuevoCobro.Click += new System.EventHandler(this.btnNuevoCobro_Click);
            // 
            // btnIniciarCaja
            // 
            this.btnIniciarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarCaja.Location = new System.Drawing.Point(211, 68);
            this.btnIniciarCaja.Name = "btnIniciarCaja";
            this.btnIniciarCaja.Size = new System.Drawing.Size(181, 35);
            this.btnIniciarCaja.TabIndex = 2;
            this.btnIniciarCaja.Text = "IniciarCaja (2)";
            this.btnIniciarCaja.UseVisualStyleBackColor = true;
            this.btnIniciarCaja.Click += new System.EventHandler(this.btnIniciarCaja_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarCaja.Location = new System.Drawing.Point(411, 68);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Size = new System.Drawing.Size(181, 35);
            this.btnCerrarCaja.TabIndex = 3;
            this.btnCerrarCaja.Text = "CerrarCaja (3)";
            this.btnCerrarCaja.UseVisualStyleBackColor = true;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Control de Caja";
            // 
            // btnRetiroCaja
            // 
            this.btnRetiroCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetiroCaja.Location = new System.Drawing.Point(614, 68);
            this.btnRetiroCaja.Name = "btnRetiroCaja";
            this.btnRetiroCaja.Size = new System.Drawing.Size(181, 35);
            this.btnRetiroCaja.TabIndex = 6;
            this.btnRetiroCaja.Text = "Retiro de Caja (4)";
            this.btnRetiroCaja.UseVisualStyleBackColor = true;
            this.btnRetiroCaja.Click += new System.EventHandler(this.btnRetiroCaja_Click);
            // 
            // btnOtrosMovimientos
            // 
            this.btnOtrosMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtrosMovimientos.Location = new System.Drawing.Point(813, 68);
            this.btnOtrosMovimientos.Name = "btnOtrosMovimientos";
            this.btnOtrosMovimientos.Size = new System.Drawing.Size(208, 35);
            this.btnOtrosMovimientos.TabIndex = 7;
            this.btnOtrosMovimientos.Text = "Otros Movimientos (5)";
            this.btnOtrosMovimientos.UseVisualStyleBackColor = true;
            this.btnOtrosMovimientos.Click += new System.EventHandler(this.btnOtrosMovimientos_Click);
            // 
            // lblEfectivoCaja
            // 
            this.lblEfectivoCaja.AutoSize = true;
            this.lblEfectivoCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivoCaja.Location = new System.Drawing.Point(447, 127);
            this.lblEfectivoCaja.Name = "lblEfectivoCaja";
            this.lblEfectivoCaja.Size = new System.Drawing.Size(230, 29);
            this.lblEfectivoCaja.TabIndex = 9;
            this.lblEfectivoCaja.Text = "Efectivo en Caja $ ";
            // 
            // btnDeleteMov
            // 
            this.btnDeleteMov.BackgroundImage = global::DynamicBrokerCaja.Properties.Resources.iconDelete;
            this.btnDeleteMov.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteMov.Enabled = false;
            this.btnDeleteMov.Location = new System.Drawing.Point(108, 124);
            this.btnDeleteMov.Name = "btnDeleteMov";
            this.btnDeleteMov.Size = new System.Drawing.Size(50, 43);
            this.btnDeleteMov.TabIndex = 10;
            this.btnDeleteMov.UseVisualStyleBackColor = true;
            this.btnDeleteMov.Click += new System.EventHandler(this.btnDeleteMov_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::DynamicBrokerCaja.Properties.Resources.iconRefresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Location = new System.Drawing.Point(22, 124);
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
            this.ClientSize = new System.Drawing.Size(1249, 552);
            this.Controls.Add(this.btnDeleteMov);
            this.Controls.Add(this.lblEfectivoCaja);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOtrosMovimientos);
            this.Controls.Add(this.btnRetiroCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnIniciarCaja);
            this.Controls.Add(this.btnNuevoCobro);
            this.Controls.Add(this.dgvMovimientos);
            this.KeyPreview = true;
            this.Name = "ControlCaja";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Caja_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ControlCaja_KeyPress);
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
        private System.Windows.Forms.Button btnDeleteMov;
    }
}