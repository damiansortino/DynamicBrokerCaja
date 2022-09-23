using System;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class CalculadoraPoint : Form
    {
        public CalculadoraPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                double cuota = float.Parse(textBox1.Text);
                lblComisiones.Text = "$ " + (((cuota * 7) / 100) + (((cuota * 7) / 100) * 0.21)).ToString();
                lblTotalCobrar.Text = (cuota + (((cuota * 7) / 100) + (((cuota * 7) / 100) * 0.21))).ToString();
            }
            else
            {
                MessageBox.Show("Error!, Solo puede colocar números y el punto separador de centavos en este campo");
            }
        }

        private bool ValidarCampos()
        {
            double verificador = 0;
            if (double.TryParse(textBox1.Text, out verificador))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
