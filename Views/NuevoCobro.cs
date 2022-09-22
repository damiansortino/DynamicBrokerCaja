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
                    if (dtpVencimientoRecibo.Value == DateTime.MinValue)
                    {
                        lblVencimientoActual.ForeColor = Color.FromArgb(214, 27, 12);
                    }
                    
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
            tbCliente.Text = BuscarCliente(int.Parse(tbBarra.Text.Substring(22, 8)));
            dtpVencimientoRecibo.Value = BuscarVencimiento(tbBarra.Text.Substring(22, 8)).Date;

            tbPoliza.Text = tbBarra.Text.Substring(22, 8);
            tbEndoso.Text = tbBarra.Text.Substring(30, 6);
            tbImporte.Text = tbBarra.Text.Substring(6, 6) + "." + tbBarra.Text.Substring(12, 2);
            tbCuota.Text = tbBarra.Text.Substring(36, 2);
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {

                cbRama.Text = DB.Rama.ToList().Find(x => x.Codigo == tbBarra.Text.Substring(20, 2)).Nombre;
            }
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
                                        MessageBox.Show(cuota.ChildNodes[0].InnerText);

                                        
                                        if(cuota.ChildNodes[0].InnerText == int.Parse(tbBarra.Text.Substring(36, 2)).ToString())
                                        {
                                            MessageBox.Show(cuota.ChildNodes[1].InnerText);
                                            return DateTime.Parse(cuota.ChildNodes[1].InnerText);
                                        }
                                    }
                                }
                            }

                        }


                    }

                }

            }
            return DateTime.MinValue;
        }

        private string BuscarCliente(int v)
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
                                    return ((XmlNode)operacion.GetElementsByTagName("tomador")[0]).ChildNodes[0].InnerText;
                                }
                            }

                        }


                    }

                }

            }
            return "";
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
