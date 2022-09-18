using DynamicBrokerCaja.Views;
using System;
using System.Windows.Forms;

namespace DynamicBrokerCaja
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void gestionarCobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlCaja control = new ControlCaja();
            control.MdiParent = this;
            control.Show();
        }
    }
}
