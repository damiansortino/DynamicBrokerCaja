using DynamicBrokerCaja.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class NuevoCobro : Form
    {
        public NuevoCobro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, System.EventArgs e)
        {
            Movimiento movimiento = CrearMovimiento();
            if (checkBox_CobranzaSinRecibo.Checked == false)
            {
                Recibo recibo = CrearRecibo();
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    DB.Recibo.Add(recibo);
                    DB.SaveChanges();
                    Recibo ultimo = DB.Set<Recibo>().OrderByDescending(t => t.Id)
                        .FirstOrDefault();
                    movimiento.ReciboId = ultimo.Id;
                }
            }
            movimiento.CajaId = CajaAbierta().Id;
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                DB.Movimiento.Add(movimiento);
                DB.SaveChanges();
            }
            MessageBox.Show("Cobranza Registrada con éxito");
            this.Close();
        }

        private Caja CajaAbierta()
        {
            Caja UltimaCaja = new Caja();
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                UltimaCaja = DB.Set<Caja>().OrderByDescending(t => t.FechaHoraApertura)
                        .FirstOrDefault();
            }
            return UltimaCaja;
        }

        private Recibo CrearRecibo()
        {
            Recibo nuevo = new Recibo();
            nuevo.CodigoBarra = tbBarra.Text;
            nuevo.Cuota = tbCuota.Text;
            nuevo.Endoso = tbEndoso.Text;

            //Truco para parsear correctamente los decimal con comas
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            nuevo.Importe = decimal.Parse(tbImporte.Text, style, provider);
            nuevo.Poliza = tbPoliza.Text;
            nuevo.Vencimiento = dtpVencimientoRecibo.Value;
            nuevo.RamaId = ((Rama)cbRama.SelectedItem).Id;
            return nuevo;
        }

        private Movimiento CrearMovimiento()
        {
            Movimiento mov = new Movimiento();


            //Truco para parsear correctamente los decimal con comas
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            mov.Importe = decimal.Parse(tbImporte.Text, style, provider);
            mov.Fecha = DateTime.Now;
            mov.MedioPagoId = ((MedioPago)cbMedioPago.SelectedItem).Id;
            if (checkBox_CobranzaSinRecibo.Checked == true)
            {
                mov.TipoMovId = 9;
            }
            else
            {
                mov.TipoMovId = 8;
            }
            return mov;
        }

        private void NuevoCobro_Load(object sender, System.EventArgs e)
        {
            CompletarComboBox();
            btnAceptar.Enabled = false;
            tbBarra.Focus();
        }
        private void CompletarComboBox()
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                cbRama.DataSource = DB.Rama.ToList();
                cbRama.DisplayMember = "Nombre";
                cbRama.ValueMember = "Id";

                cbMedioPago.DataSource = DB.MedioPago.ToList();
                cbMedioPago.DisplayMember = "Nombre";
                cbMedioPago.ValueMember = "Id";
            }
        }

        private void tbBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                LimpiarForm();
                ComprobarLectura();
                if (ComprobarBarra())
                {
                    CompletarCampos();
                    btnAceptar.Enabled = true;
                    e.Handled = true;
                    cbMedioPago.Focus();
                }
                else
                {
                    tbBarra.Clear();
                    tbBarra.Focus();
                }
                
            }
            else
            {
                btnAceptar.Enabled = false;
            }

        }
        private void LimpiarForm()
        {
            tbPoliza.Text = "";
            tbEndoso.Text = "";
            tbImporte.Text = "";
            tbCuota.Text = "";
        }

        private void CompletarCampos()
        {
            tbPoliza.Text = tbBarra.Text.Substring(22, 8);
            tbEndoso.Text = tbBarra.Text.Substring(30, 6);
            tbImporte.Text = tbBarra.Text.Substring(6, 6) + "." + tbBarra.Text.Substring(12, 2);
            tbCuota.Text = tbBarra.Text.Substring(36, 2);
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                cbRama.Text = DB.Rama.ToList().Find(x => x.Codigo == tbBarra.Text.Substring(20, 2)).Nombre;
            }
        }

        private void ComprobarLectura()
        {
            if (tbBarra.TextLength != 40)
            {
                tbBarra.Clear();
                tbBarra.Focus();
                MessageBox.Show("Error de lectura, vuelva a intentarlo");

            }
            else
            {

                if (tbBarra.Text.Substring(0, 6) == "094057")
                {
                    tbBarra.Clear();
                    tbBarra.Focus();
                    MessageBox.Show("No está habilitada la cobranza de Recibos " +
                        "de Caledonia con códigos de Barra todavía");
                }
            }

        }

        private bool ComprobarBarra()
        {
            if (tbBarra.TextLength != 40)
            {
                tbBarra.Clear();
                return false;
            }

            if (tbBarra.Text.Substring(0, 6) == "094330")
            {
                return true;
            }
            else
            {
                tbBarra.Clear();
                return false;
            }
        }

        private void tbBarra_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
