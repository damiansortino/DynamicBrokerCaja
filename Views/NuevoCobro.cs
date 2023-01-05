using DynamicBrokerCaja.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

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

            Recibo recibo = CrearRecibo();
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                DB.Recibo.Add(recibo);
                DB.SaveChanges();
                Recibo ultimo = DB.Set<Recibo>().OrderByDescending(t => t.Id)
                    .FirstOrDefault();
                movimiento.ReciboId = ultimo.Id;
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
            mov.TipoMovId = 8;
            return mov;
        }

        private void NuevoCobro_Load(object sender, System.EventArgs e)
        {
            dtpVencimientoRecibo.Value = DateTime.Now;
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

                if (ComprobarLectura())
                {
                    if (ComprobarBarra())
                    {
                        if (ExistePolizaInterfaz())
                        {
                            CompletarCampos();
                            btnAceptar.Enabled = true;
                            lblVencimientoActual.ForeColor = Color.FromArgb(46, 194, 23);
                            e.Handled = true;
                            cbMedioPago.Focus();
                        }
                        else
                        {
                            lblVencimientoActual.ForeColor = Color.FromArgb(214, 27, 12);
                            MessageBox.Show("No se encontró información en la interfaz, deberá completar manualmente el campo 'vencimiento'");
                            CompletarReciboBasico();

                            btnAceptar.Enabled = true;
                            e.Handled = true;
                            cbMedioPago.Focus();
                        }

                    }
                    else
                    {
                        tbBarra.Clear();
                        tbBarra.Focus();
                        MessageBox.Show("No se reconoce el comprobante, intente nuevamente");
                    }
                }
                else
                {
                    MessageBox.Show("Lectura incorrecta, intente nuevamente");
                }


            }
            else
            {
                btnAceptar.Enabled = false;
            }

        }

        private bool ComprobarLectura()
        {
            if (tbBarra.TextLength != 40)
            {
                tbBarra.Clear();
                tbBarra.Focus();
                return false;

            }
            else
            {
                if (tbBarra.Text.Substring(0, 6) != "094330")
                {
                    tbBarra.Clear();
                    tbBarra.Focus();
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void CompletarReciboBasico()
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

        private bool ExistePolizaInterfaz()
        {
            DirectoryInfo folder = new DirectoryInfo(ConfigurationManager.ConnectionStrings["InterfazParana"].ConnectionString + "/Emision");
            IEnumerable<FileInfo> files = folder.GetFiles().OrderBy(x => x.CreationTime);
            XmlDocument documento = new XmlDocument();

            foreach (var item in files)
            {
                documento.Load(item.FullName);
                foreach (XmlElement elemento in documento.DocumentElement)
                {
                    if (elemento.Name == "operaciones")
                    {
                        foreach (XmlElement operacion in elemento.ChildNodes)
                        {
                            foreach (XmlElement campo in operacion.ChildNodes)
                            {
                                if ((campo.Name == "poliza" && campo.InnerText == tbBarra.Text.Substring(22, 8).ToString().Trim()) || (campo.Name == "asociada" && campo.InnerText == tbBarra.Text.Substring(22, 8).ToString().Trim()))
                                {
                                    return true;
                                }
                            }
                        }


                    }

                }

            }
            return false;
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
            tbCliente.Text = BuscarCliente(int.Parse(tbBarra.Text.Substring(22, 8)));
            dtpVencimientoRecibo.Value = BuscarVencimiento(tbBarra.Text.Substring(22, 8)).Date;
            tbPoliza.Text = PolizadeInterfaz(tbBarra.Text.Substring(22, 8));

            tbEndoso.Text = tbBarra.Text.Substring(30, 6);
            tbImporte.Text = tbBarra.Text.Substring(6, 6) + "." + tbBarra.Text.Substring(12, 2);
            tbCuota.Text = tbBarra.Text.Substring(36, 2);
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                cbRama.Text = DB.Rama.ToList().Find(x => x.Codigo == tbBarra.Text.Substring(20, 2)).Nombre;
            }
        }

        private string PolizadeInterfaz(string v)
        {
            DirectoryInfo folder = new DirectoryInfo(ConfigurationManager.ConnectionStrings["InterfazParana"].ConnectionString + "/Emision");
            IEnumerable<FileInfo> files = folder.GetFiles().OrderBy(x => x.CreationTime);
            XmlDocument documento = new XmlDocument();

            foreach (var item in files)
            {
                documento.Load(item.FullName);
                foreach (XmlElement elemento in documento.DocumentElement)
                {
                    if (elemento.Name == "operaciones")
                    {
                        foreach (XmlElement operacion in elemento.ChildNodes)
                        {
                            foreach (XmlElement campo in operacion.ChildNodes)
                            {
                                if ((campo.Name == "poliza" && campo.InnerText == v || (campo.Name == "asociada" && campo.InnerText == v)))
                                {
                                    return operacion.ChildNodes[1].InnerText;
                                }
                            }
                        }


                    }

                }

            }
            return v;
        }

        private DateTime BuscarVencimiento(string v)
        {
            DirectoryInfo folder = new DirectoryInfo(ConfigurationManager.ConnectionStrings["InterfazParana"].ConnectionString + "/Emision");
            IEnumerable<FileInfo> files = folder.GetFiles().OrderBy(x => x.CreationTime);
            XmlDocument documento = new XmlDocument();

            foreach (var item in files)
            {
                documento.Load(item.FullName);
                foreach (XmlElement elemento in documento.DocumentElement)
                {
                    if (elemento.Name == "operaciones")
                    {
                        foreach (XmlElement operacion in elemento.ChildNodes)
                        {
                            foreach (XmlElement campo in operacion.ChildNodes)
                            {
                                if ((campo.Name == "poliza" && campo.InnerText == v.ToString().Trim()) || (campo.Name == "asociada" && campo.InnerText == v.ToString().Trim()))
                                {
                                    XmlNodeList lista = operacion.GetElementsByTagName("cuotas");

                                    foreach (XmlNode cuota in lista[0])
                                    {

                                        if (cuota.ChildNodes[0].InnerText == int.Parse(tbBarra.Text.Substring(36, 2)).ToString())
                                        {
                                            return DateTime.Parse(cuota.ChildNodes[1].InnerText);
                                        }
                                    }
                                }
                            }

                        }


                    }

                }

            }
            return DateTime.Now;
        }

        private string BuscarCliente(int v)
        {
            DirectoryInfo folder = new DirectoryInfo(ConfigurationManager.ConnectionStrings["InterfazParana"].ConnectionString + "/Emision");
            IEnumerable<FileInfo> files = folder.GetFiles().OrderBy(x => x.CreationTime);
            XmlDocument documento = new XmlDocument();
            string devolver = "";

            foreach (var item in files)
            {
                documento.Load(item.FullName);
                foreach (XmlElement elemento in documento.DocumentElement)
                {
                    if (elemento.Name == "operaciones")
                    {
                        foreach (XmlElement operacion in elemento.ChildNodes)
                        {
                            foreach (XmlElement campo in operacion.ChildNodes)
                            {
                                if ((campo.Name == "poliza" && campo.InnerText == v.ToString().Trim()) || (campo.Name == "asociada" && campo.InnerText == v.ToString().Trim()))
                                {
                                    return ((XmlNode)operacion.GetElementsByTagName("tomador")[0]).ChildNodes[0].InnerText;
                                }
                            }
                        }


                    }

                }

            }
            return devolver;
        }


        private bool ComprobarBarra()
        {
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

        private void cbMedioPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnAceptar.Focus();
            }
        }
    }
}
