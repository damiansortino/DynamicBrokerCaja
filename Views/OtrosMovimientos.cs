using DynamicBrokerCaja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class OtrosMovimientos : Form
    {
        public OtrosMovimientos()
        {
            InitializeComponent();
        }

        private void OtrosMovimientos_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                List<TipoMovimientoCaja> tipo = DB.TipoMovimientoCaja.ToList().FindAll(x=>x.FechaBaja == null);
                cbTipoMovimiento.DataSource = tipo;
                cbTipoMovimiento.DisplayMember = "Nombre";
                cbTipoMovimiento.ValueMember = "Id";

                List<MedioPago> medios = DB.MedioPago.ToList();
                cbMedioPago.DataSource = medios;
                cbMedioPago.DisplayMember = "Nombre";
                cbMedioPago.ValueMember = "Id";
                
                tbImporte.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                if(radioEntrada.Checked == true)
                {
                    Movimiento nuevo = CrearMovimiento();
                    GuardarMovimiento(nuevo);
                    this.Close();

                    MessageBox.Show("Movimiento exitoso" + " \n Actualmente hay $ " + ImporteCaja().ToString() + " en su caja.");

                }
                else
                {
                    if (VerificarMontoEgreso())
                    {
                        Movimiento nuevo = CrearMovimiento();
                        GuardarMovimiento(nuevo);
                        this.Close();

                        MessageBox.Show("Movimiento existoso" + " \n Actualmente hay $ " + ImporteCaja().ToString() + " en su caja.");

                    }
                    else
                    {
                        tbImporte.Clear();
                        tbImporte.Focus();
                        MessageBox.Show("No es posible realizar esta operación, el dinero disponible en la caja" +
                        " no es suficiente para el movimiento que intenta realizar." + "\n" + "Efectivo en Caja $ " + ImporteCaja());
                    }

                }
                
                
            }
            else
            {
                tbImporte.Focus();
                MessageBox.Show(" Error, El campo de importe solo admite números y .(punto) para separar los centavos");
            }
            
            
        }

        private bool VerificarMontoEgreso()
        {
            //Truco para parsear correctamente los decimal con comas
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            decimal montoretiro = decimal.Parse(tbImporte.Text, style, provider);
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
            Movimiento mov = new Movimiento();

            //Truco para parsear correctamente los decimal con punto
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            mov.Importe = decimal.Parse(tbImporte.Text, style, provider);
            mov.Fecha = DateTime.Now;
            mov.MedioPagoId = ((MedioPago)cbMedioPago.SelectedItem).Id;
            mov.TipoMovId = ((TipoMovimientoCaja)cbTipoMovimiento.SelectedItem).Id;

            if (radioEntrada.Checked == true)
            {
                mov.Importe = decimal.Parse(tbImporte.Text, style, provider);
            }
            else
            {
                mov.Importe = -decimal.Parse(tbImporte.Text, style, provider);
            }
            mov.CajaId = CajaActual().Id;

            return mov;
        }

        private Caja CajaActual()
        {
            Caja actual = new Caja();
  
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                actual = DB.Caja.ToList().Find(x=>x.FechaHoraCierre == null);
            }
            return actual;
        }

        private bool VerificarCampos()
        {
            decimal valor;
            if(decimal.TryParse(tbImporte.Text,out valor))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
