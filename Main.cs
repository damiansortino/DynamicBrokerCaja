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

        private void carpetaDeInterfazParanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigInterParana cip = new ConfigInterParana();
            cip.MdiParent = ParentForm;
            cip.Show();
        }

        private void calcularCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculadoraPoint ventana = new CalculadoraPoint();
            ventana.MdiParent = ParentForm;
            ventana.Show();
        }

        private void cobradosEnOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CobradosOficina cobof = new CobradosOficina();
            cobof.MdiParent = ParentForm;
            cobof.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void iPDelServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
