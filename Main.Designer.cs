
namespace DynamicBrokerCaja
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verCajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCajasAnterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpetaDeInterfazParanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCajasToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verCajasToolStripMenuItem
            // 
            this.verCajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCobrosToolStripMenuItem,
            this.verCajasAnterioresToolStripMenuItem});
            this.verCajasToolStripMenuItem.Name = "verCajasToolStripMenuItem";
            this.verCajasToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.verCajasToolStripMenuItem.Text = "Caja";
            // 
            // gestionarCobrosToolStripMenuItem
            // 
            this.gestionarCobrosToolStripMenuItem.Name = "gestionarCobrosToolStripMenuItem";
            this.gestionarCobrosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.gestionarCobrosToolStripMenuItem.Text = "CONTROL DE CAJA";
            this.gestionarCobrosToolStripMenuItem.Click += new System.EventHandler(this.gestionarCobrosToolStripMenuItem_Click);
            // 
            // verCajasAnterioresToolStripMenuItem
            // 
            this.verCajasAnterioresToolStripMenuItem.Name = "verCajasAnterioresToolStripMenuItem";
            this.verCajasAnterioresToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.verCajasAnterioresToolStripMenuItem.Text = "VER CAJAS ANTERIORES";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carpetaDeInterfazParanaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // carpetaDeInterfazParanaToolStripMenuItem
            // 
            this.carpetaDeInterfazParanaToolStripMenuItem.Name = "carpetaDeInterfazParanaToolStripMenuItem";
            this.carpetaDeInterfazParanaToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.carpetaDeInterfazParanaToolStripMenuItem.Text = "Carpeta de interfaz Parana";
            this.carpetaDeInterfazParanaToolStripMenuItem.Click += new System.EventHandler(this.carpetaDeInterfazParanaToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Broker Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verCajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCajasAnterioresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpetaDeInterfazParanaToolStripMenuItem;
    }
}

