
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
            this.iPDelServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoMovimientoCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paranaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobranzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularCuotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobradosEnOficinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbar_1 = new System.Windows.Forms.ProgressBar();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verCajasToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.interfazToolStripMenuItem,
            this.mercadoPointToolStripMenuItem,
            this.recibosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verCajasToolStripMenuItem
            // 
            this.verCajasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCobrosToolStripMenuItem,
            this.verCajasAnterioresToolStripMenuItem});
            this.verCajasToolStripMenuItem.Name = "verCajasToolStripMenuItem";
            this.verCajasToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.verCajasToolStripMenuItem.Text = "Caja";
            // 
            // gestionarCobrosToolStripMenuItem
            // 
            this.gestionarCobrosToolStripMenuItem.Name = "gestionarCobrosToolStripMenuItem";
            this.gestionarCobrosToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.gestionarCobrosToolStripMenuItem.Text = "CONTROL DE CAJA";
            this.gestionarCobrosToolStripMenuItem.Click += new System.EventHandler(this.gestionarCobrosToolStripMenuItem_Click);
            // 
            // verCajasAnterioresToolStripMenuItem
            // 
            this.verCajasAnterioresToolStripMenuItem.Name = "verCajasAnterioresToolStripMenuItem";
            this.verCajasAnterioresToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.verCajasAnterioresToolStripMenuItem.Text = "VER CAJAS ANTERIORES";
            this.verCajasAnterioresToolStripMenuItem.Click += new System.EventHandler(this.verCajasAnterioresToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carpetaDeInterfazParanaToolStripMenuItem,
            this.iPDelServidorToolStripMenuItem,
            this.tipoMovimientoCajaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // carpetaDeInterfazParanaToolStripMenuItem
            // 
            this.carpetaDeInterfazParanaToolStripMenuItem.Name = "carpetaDeInterfazParanaToolStripMenuItem";
            this.carpetaDeInterfazParanaToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.carpetaDeInterfazParanaToolStripMenuItem.Text = "Carpeta de interfaz Parana";
            this.carpetaDeInterfazParanaToolStripMenuItem.Click += new System.EventHandler(this.carpetaDeInterfazParanaToolStripMenuItem_Click);
            // 
            // iPDelServidorToolStripMenuItem
            // 
            this.iPDelServidorToolStripMenuItem.Name = "iPDelServidorToolStripMenuItem";
            this.iPDelServidorToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.iPDelServidorToolStripMenuItem.Text = "IP del Servidor";
            this.iPDelServidorToolStripMenuItem.Click += new System.EventHandler(this.iPDelServidorToolStripMenuItem_Click);
            // 
            // tipoMovimientoCajaToolStripMenuItem
            // 
            this.tipoMovimientoCajaToolStripMenuItem.Name = "tipoMovimientoCajaToolStripMenuItem";
            this.tipoMovimientoCajaToolStripMenuItem.Size = new System.Drawing.Size(308, 30);
            this.tipoMovimientoCajaToolStripMenuItem.Text = "Tipo Movimiento Caja";
            // 
            // interfazToolStripMenuItem
            // 
            this.interfazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paranaToolStripMenuItem});
            this.interfazToolStripMenuItem.Name = "interfazToolStripMenuItem";
            this.interfazToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.interfazToolStripMenuItem.Text = "Interfaz";
            // 
            // paranaToolStripMenuItem
            // 
            this.paranaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emisionToolStripMenuItem,
            this.cobranzaToolStripMenuItem});
            this.paranaToolStripMenuItem.Name = "paranaToolStripMenuItem";
            this.paranaToolStripMenuItem.Size = new System.Drawing.Size(142, 30);
            this.paranaToolStripMenuItem.Text = "Paraná";
            // 
            // emisionToolStripMenuItem
            // 
            this.emisionToolStripMenuItem.Name = "emisionToolStripMenuItem";
            this.emisionToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.emisionToolStripMenuItem.Text = "Emisión";
            this.emisionToolStripMenuItem.Click += new System.EventHandler(this.emisionToolStripMenuItem_Click);
            // 
            // cobranzaToolStripMenuItem
            // 
            this.cobranzaToolStripMenuItem.Name = "cobranzaToolStripMenuItem";
            this.cobranzaToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.cobranzaToolStripMenuItem.Text = "Cobranza";
            // 
            // mercadoPointToolStripMenuItem
            // 
            this.mercadoPointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularCuotaToolStripMenuItem});
            this.mercadoPointToolStripMenuItem.Name = "mercadoPointToolStripMenuItem";
            this.mercadoPointToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.mercadoPointToolStripMenuItem.Text = "MercadoPoint";
            // 
            // calcularCuotaToolStripMenuItem
            // 
            this.calcularCuotaToolStripMenuItem.Name = "calcularCuotaToolStripMenuItem";
            this.calcularCuotaToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.calcularCuotaToolStripMenuItem.Text = "Calcular Cuota";
            this.calcularCuotaToolStripMenuItem.Click += new System.EventHandler(this.calcularCuotaToolStripMenuItem_Click);
            // 
            // recibosToolStripMenuItem
            // 
            this.recibosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobradosEnOficinaToolStripMenuItem});
            this.recibosToolStripMenuItem.Name = "recibosToolStripMenuItem";
            this.recibosToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.recibosToolStripMenuItem.Text = "Recibos";
            // 
            // cobradosEnOficinaToolStripMenuItem
            // 
            this.cobradosEnOficinaToolStripMenuItem.Name = "cobradosEnOficinaToolStripMenuItem";
            this.cobradosEnOficinaToolStripMenuItem.Size = new System.Drawing.Size(250, 30);
            this.cobradosEnOficinaToolStripMenuItem.Text = "cobrados en oficina";
            this.cobradosEnOficinaToolStripMenuItem.Click += new System.EventHandler(this.cobradosEnOficinaToolStripMenuItem_Click);
            // 
            // pbar_1
            // 
            this.pbar_1.Location = new System.Drawing.Point(30, 61);
            this.pbar_1.Name = "pbar_1";
            this.pbar_1.Size = new System.Drawing.Size(407, 23);
            this.pbar_1.TabIndex = 3;
            this.pbar_1.Visible = false;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarInterfaceToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // actualizarInterfaceToolStripMenuItem
            // 
            this.actualizarInterfaceToolStripMenuItem.Name = "actualizarInterfaceToolStripMenuItem";
            this.actualizarInterfaceToolStripMenuItem.Size = new System.Drawing.Size(247, 30);
            this.actualizarInterfaceToolStripMenuItem.Text = "Actualizar interface";
            this.actualizarInterfaceToolStripMenuItem.Click += new System.EventHandler(this.actualizarInterfaceToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbar_1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamic Broker Caja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
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
        private System.Windows.Forms.ToolStripMenuItem interfazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paranaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobranzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularCuotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recibosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobradosEnOficinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPDelServidorToolStripMenuItem;
        private System.Windows.Forms.ProgressBar pbar_1;
        private System.Windows.Forms.ToolStripMenuItem tipoMovimientoCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarInterfaceToolStripMenuItem;
    }
}

