using DynamicBrokerCaja.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class CerrarCajaView : Form
    {

        public CerrarCajaView()
        {
            InitializeComponent();
        }

        Caja cajacerrar = new Caja();
        decimal montoactual = 0;

        public CerrarCajaView(int id)
        {
            InitializeComponent();
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                cajacerrar = DB.Caja.Find(id);
                ActualizarMontoCaja();
            }
        }

        private void ActualizarMontoCaja()
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                montoactual = 0;
                List<Movimiento> movimientos = DB.Movimiento.ToList().FindAll(x => x.CajaId == cajacerrar.Id && x.FechaBaja == null);
                foreach (Movimiento item in movimientos)
                {
                    if (item.MedioPagoId == 1)
                    {
                        montoactual = montoactual + item.Importe;
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            //Truco para parsear correctamente los decimal con comas
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            try
            {
                if (ValidarCampo())
                {
                    if (DiferenciaCaja())
                    {
                        if (SobranteFaltanteCaja())
                        {
                            ActualizarMontoCaja();
                            decimal diferencia = decimal.Parse(tbImporteCierre.Text, style, provider) - montoactual;
                            lblDiferenciaCaja.Text = "Ud tiene un sobrante de caja de $ " + diferencia;
                            lblDiferenciaCaja.ForeColor = Color.FromArgb(214, 27, 12);
                        }
                        else
                        {
                            ActualizarMontoCaja();
                            decimal diferencia = montoactual - decimal.Parse(tbImporteCierre.Text, style, provider);
                            lblDiferenciaCaja.Text = "Ud tiene un faltante de caja de $ " + diferencia;
                            lblDiferenciaCaja.ForeColor = Color.FromArgb(214, 27, 12);
                        }
                        lblDiferenciaCaja.Visible = true;
                    }
                    else
                    {
                        lblDiferenciaCaja.Text = "Su caja cierra correctamente";
                        lblDiferenciaCaja.ForeColor = Color.FromArgb(46, 194, 23);
                        lblDiferenciaCaja.Visible = true;
                    }
                    btnCerrarCaja.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error!, Solo se permiten números en este campo separando los centavos con un punto");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error validando campos");
            }

        }

        private bool SobranteFaltanteCaja()
        {
            ActualizarMontoCaja();
            if (montoactual > decimal.Parse(tbImporteCierre.Text)) return false;
            else return true;
        }

        private bool DiferenciaCaja()
        {
            //Truco para parsear correctamente los decimal con comas
            NumberStyles style;
            CultureInfo provider;
            style = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands;
            provider = new CultureInfo("en-US");
            //fintruco

            ActualizarMontoCaja();
            if (montoactual != decimal.Parse(tbImporteCierre.Text, style, provider))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private bool ValidarCampo()
        {
            bool esNumero = true;

            try
            {
                decimal n = 0;
                esNumero = decimal.TryParse(tbImporteCierre.Text.Trim(), out n);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en validación de campo número");
            }
            return esNumero;
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            Movimiento movimientocierre = new Movimiento();
            cajacerrar.FechaHoraCierre = DateTime.Now;
            movimientocierre.CajaId = cajacerrar.Id;
            movimientocierre.MedioPagoId = 1;
            movimientocierre.Fecha = (DateTime)cajacerrar.FechaHoraCierre;

            if (DiferenciaCaja())
            {
                if (SobranteFaltanteCaja())
                {
                    ActualizarMontoCaja();
                    movimientocierre.TipoMovId = 7;
                    movimientocierre.Importe = decimal.Parse(tbImporteCierre.Text.Trim()) - montoactual;
                    using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                    {
                        DB.Movimiento.Add(movimientocierre);
                        DB.SaveChanges();

                        movimientocierre.Importe = 0;
                        movimientocierre.TipoMovId = 2;
                        movimientocierre.Fecha = DateTime.Now;
                        DB.Movimiento.Add(movimientocierre);
                        DB.SaveChanges();
                    }
                    movimientocierre.Importe = 0;
                    movimientocierre.TipoMovId = 2;
                }
                else
                {
                    ActualizarMontoCaja();
                    movimientocierre.TipoMovId = 6;
                    movimientocierre.Importe = montoactual - decimal.Parse(tbImporteCierre.Text.Trim());
                    using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                    {
                        DB.Movimiento.Add(movimientocierre);
                        DB.SaveChanges();

                        movimientocierre.Importe = 0;
                        movimientocierre.TipoMovId = 2;
                        movimientocierre.Fecha = DateTime.Now;
                        DB.Movimiento.Add(movimientocierre);
                        DB.SaveChanges();
                    }
                }
            }
            else
            {
                movimientocierre.TipoMovId = 2;
                movimientocierre.Importe = 0;
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    DB.Movimiento.Add(movimientocierre);
                    DB.SaveChanges();
                }
            }
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                cajacerrar.Cierre = decimal.Parse(tbImporteCierre.Text.Trim());
                DB.Entry(cajacerrar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
            }
            MessageBox.Show("Caja Cerrada Correctamente");

            this.Close();
        }

        private void tbImporteCierre_MouseClick(object sender, MouseEventArgs e)
        {
            btnCerrarCaja.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbImporteCierre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                btnOK.PerformClick();
            }
        }
    }
}