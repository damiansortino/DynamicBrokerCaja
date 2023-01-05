using DynamicBrokerCaja.Views;
using System;
using System.Linq;
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
            /*
            ControlCaja control = new ControlCaja();
            control.MdiParent = this;
            control.Show();
            */

            Form control = this.MdiChildren.FirstOrDefault(x => x is ControlCaja);
            if (control != null)
            {
                control.BringToFront();
            }
            else
            {
                control = new ControlCaja();
                control.MdiParent = this;
                control.Show();
            }
        }

        private void carpetaDeInterfazParanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigInterParana cip = new ConfigInterParana();
            cip.MdiParent = ParentForm;
            cip.Show();
        }

        private void calcularCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ventana = this.MdiChildren.FirstOrDefault(x => x is CalculadoraPoint);

            if (ventana != null)
            {
                ventana.BringToFront();
            }
            else
            {
                ventana = new CalculadoraPoint();
                ventana.MdiParent = this;
                ventana.Show();
            }
        }

        private void cobradosEnOficinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form cobof = this.MdiChildren.FirstOrDefault(x => x is CobradosOficina);

            if (cobof != null)
            {
                //si la instancia existe la pongo en primer plano
                cobof.BringToFront();
                return;
            }

            //se abre el form de clientes
            cobof = new CobradosOficina();
            cobof.MdiParent = this;
            cobof.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {


        }




        private void iPDelServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void verCajasAnterioresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cajasanteriores = this.MdiChildren.FirstOrDefault(x => x is CajasAnteriores);
            if (cajasanteriores != null)
            {
                cajasanteriores.BringToFront();
            }
            else
            {
                cajasanteriores = new CajasAnteriores();
                cajasanteriores.MdiParent = this;
                cajasanteriores.Show();
            }
        }
    }
}
