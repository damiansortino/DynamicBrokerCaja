using DynamicBrokerCaja.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class IniciarCaja : Form
    {
        public IniciarCaja()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    Caja nuevacaja = new Caja();

                    nuevacaja.FechaHoraApertura = DateTime.Now;
                    nuevacaja.Apertura = decimal.Parse(tbEfectivoCaja.Text);

                    Movimiento movinicial = new Movimiento();
                    movinicial.Importe = (decimal)nuevacaja.Apertura;
                    movinicial.Fecha = nuevacaja.FechaHoraApertura;

                    DB.Caja.Add(nuevacaja);
                    DB.SaveChanges();

                    int IdUltimaCaja = DB.Set<Caja>().OrderByDescending(t => t.FechaHoraApertura)
                        .FirstOrDefault().Id;
                    movinicial.CajaId = IdUltimaCaja;
                    movinicial.TipoMovId = 1;
                    movinicial.MedioPagoId = 1;

                    DB.Movimiento.Add(movinicial);
                    DB.SaveChanges();
                    MessageBox.Show("Caja iniciada correctamente");
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error al iniciar Caja");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbEfectivoCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                btnIniciar.Focus();
            }
        }
    }
}
