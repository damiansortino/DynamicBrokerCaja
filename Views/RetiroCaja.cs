using DynamicBrokerCaja.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class RetiroCaja : Form
    {
        public RetiroCaja()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if (VerificarMontoRetiro())
                {
                    Movimiento nuevo = CrearMovimiento();
                    GuardarMovimiento(nuevo);

                    MessageBox.Show("Retiro Existoso" + " Actualmente hay $ " + ImporteCaja().ToString() + " en su caja.");

                }
                else
                {
                    MessageBox.Show("No es posible realizar esta operación, el dinero disponible en la caja" +
                    " no es suficiente para el retiro que intenta realizar." +"\n"+"Efectivo en Caja $ " + ImporteCaja());
                   
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error, compruebe que todos los campos estén completos");
            }
            this.Close();
        }

        private bool VerificarMontoRetiro()
        {
            //Truco para parsear correctamente los decimal con comas
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            decimal montoretiro = decimal.Parse(tbImporte.Text,style,provider);
            if (montoretiro > ImporteCaja())
            {
                return false;
            }
            return true;
        }

        private decimal ImporteCaja()
        {
            decimal montocaja = 0;
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                List<Movimiento> movimientos = DB.Movimiento.ToList().FindAll(x => x.CajaId == CajaActual().Id && x.FechaBaja==null);
                foreach (Movimiento item in movimientos)
                {
                    montocaja = montocaja + item.Importe;
                }
            }
            return montocaja;
        }

        private void GuardarMovimiento(Movimiento nuevo)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                DB.Movimiento.Add(nuevo);
                DB.SaveChanges();
            }
        }

        private Movimiento CrearMovimiento()
        {
            Movimiento crear = new Movimiento();
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                //Truco para parsear correctamente los decimal con comas
                NumberStyles style;
                CultureInfo provider;
                style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
                provider = new CultureInfo("en-US");
                //fintruco

                crear.CajaId = CajaActual().Id;
                crear.Fecha = DateTime.Now;
                crear.Importe = -decimal.Parse(tbImporte.Text,style,provider);
                crear.MedioPagoId = 1;
                crear.TipoMovId = 3;
            }
            return crear;
        }

        private Caja CajaActual()
        {
            Caja actual = new Caja();
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                actual = DB.Caja.ToList().Find(x => x.FechaHoraCierre == null);
            }
            return actual;
        }

        private bool VerificarCampos()
        {
            decimal prueba;
            if (decimal.TryParse(tbImporte.Text, out prueba))
            {
                return true;
            }
            return false;
        }
    }
}
