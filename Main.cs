using DynamicBrokerCaja.Models;
using DynamicBrokerCaja.Models.Auxiliares;
using DynamicBrokerCaja.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

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
            else
            {
                //se abre el form de clientes
                cobof = new CobradosOficina();
                cobof.MdiParent = this;
                cobof.Show();
            }


        }

        private void Main_Load(object sender, EventArgs e)
        {
            //ActualizarClientesDB();
            AbrirFormCaja();
        }



        private void ActualizarClientesDB()
        {
            
            int contador_nuevosclientes = 0;
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                
                List<Emision_Interfaz> emisiones = new List<Emision_Interfaz>();

                DirectoryInfo folder = new DirectoryInfo(ConfigurationManager.ConnectionStrings["InterfazParana"].ConnectionString + "/Emision");
                IEnumerable<FileInfo> files = folder.GetFiles().OrderBy(x => x.CreationTime);
                XmlDocument documento = new XmlDocument();

                foreach (var item in files)
                {
                    pbar_1.Visible = false;
                    documento.Load(item.FullName);
                    
                    foreach (XmlElement elemento in documento.DocumentElement)
                    {
                        if (elemento.Name == "operaciones")
                        {
                            foreach (XmlElement nodo in elemento.ChildNodes)
                            {
                                if (nodo.Name == "operacion")
                                {
                                    if (nodo.ChildNodes[12].InnerText == "11" || nodo.ChildNodes[12].InnerText == "2")
                                    {
                                        Emision_Interfaz nuevaoperacion = new Emision_Interfaz(nodo);
                                        emisiones.Add(nuevaoperacion);
                                    }
                                }
                            }

                        }
                    }
                }
                pbar_1.Visible = true;
                
                pbar_1.Maximum = emisiones.Count();
                pbar_1.Step = 1;
                pbar_1.Enabled = true;

                foreach (Emision_Interfaz item in emisiones)
                {
                    for (int i = 0; i < emisiones.Count(); i++)
                    {
                        if (i % emisiones.Count() == 0)
                        {
                            pbar_1.PerformStep();
                        }
                    }

                    if (!ExisteCliente(item.tomador_dni)) //comprobar que no existe el cliente aqui
                    {
                        Cliente nuevocliente = new Cliente();
                        nuevocliente.ApellidoNombre = item.tomador_nombre;
                        nuevocliente.DNI = item.tomador_dni;
                        nuevocliente.Domicilio = item.tomador_domicilio + " - " + item.tomador_ciudad + " - " + item.tomador_provincia;
                        nuevocliente.FechaAlta = DateTime.Now.Date;
                        if (item.condiva != "5")
                        {
                            nuevocliente.CondFiscalId = 1;
                        }
                        else
                        {
                            nuevocliente.CondFiscalId = 3;
                        }

                        DB.Cliente.Add(nuevocliente);
                        DB.SaveChanges();
                        contador_nuevosclientes++;
                        pbar_1.Enabled = false;
                        pbar_1.Visible = false;
                        

                    }
                }

            }

            gestionarCobrosToolStripMenuItem.PerformClick();

            pbar_1.Visible = false;
            MessageBox.Show("La interfaz contenía un total de "
                + contador_nuevosclientes + " nuevos clientes que fueron agregados al sistema");
        }

        private bool ExisteCliente(string tomador_dni)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                foreach (Cliente item in DB.Cliente.ToList().FindAll(x => x.fechabaja == null))
                {
                    if (item.DNI == tomador_dni)
                    {
                        return true;
                    }
                }

            }

            return false;
        }

        private void AbrirFormCaja()
        {
            Form caja = this.MdiChildren.FirstOrDefault(x => x is ControlCaja);
            if (caja != null)
            {
                caja.BringToFront();
            }
            else
            {
                caja = new ControlCaja();
                caja.MdiParent = this;
                caja.Show();
            }
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

        private void emisionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actualizarInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarClientesDB();
        }
    }
}
