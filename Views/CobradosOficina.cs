using DynamicBrokerCaja.Models;
using DynamicBrokerCaja.Models.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class CobradosOficina : Form
    {
        public CobradosOficina()
        {
            InitializeComponent();
        }

        private void CobradosOficina_Load(object sender, EventArgs e)
        {
            cboxCriterio.Text = "Póliza";
            tbFiltro.Focus();
            UltimasCobranzas();
        }

        private void UltimasCobranzas()
        {
            List<RecibosDGV> lista = new List<RecibosDGV>();

            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                foreach (Movimiento mov in DB.Movimiento)
                {
                    if (mov.Fecha >= DateTime.Now.AddDays(-10))
                    {
                        if (mov.FechaBaja == null && mov.TipoMovId == 8)
                        {
                            RecibosDGV nuevorecibo = new RecibosDGV(DB.Recibo.Find(mov.ReciboId));
                            lista.Add(nuevorecibo);
                        }
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void LlenarDGV()
        {
            List<RecibosDGV> lista = new List<RecibosDGV>();
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                foreach (Recibo item in DB.Recibo)
                {
                    if (item.FechaBaja == null)
                    {
                        RecibosDGV nuevorecibo = new RecibosDGV(item);
                        lista.Add(nuevorecibo);
                    }
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarDGV();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarResultados(cboxCriterio.Text, tbFiltro.Text.ToLower().Trim());
        }

        private void MostrarResultados(string criterio, string filtro)
        {
            //////////Criterio póliza /////

            List<RecibosDGV> lista = new List<RecibosDGV>();
            if (criterio == "Póliza")
            {
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    foreach (Recibo item in DB.Recibo.ToList().FindAll(x => x.FechaBaja == null))
                    {
                        if (int.Parse(item.Poliza) == int.Parse(filtro.Trim()))
                        {
                            RecibosDGV nuevorecibo = new RecibosDGV(item);
                            lista.Add(nuevorecibo);
                        }
                    }
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }

            //////////Criterio 

            if (criterio != "Póliza")
            {
                MessageBox.Show("Ups, todavía no se puede buscar por este" +
                    " criterio, en breve estará disponible. Mientras " +
                    "tanto podés utilizar esta función buscando por número de póliza");
            }


            //continuar programando los demas criterios de búsqueda

            ////////////Criterio Patente ////////////



        }



        private void tbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                Movimiento seleccionado = DB.Movimiento.ToList()
                    .FindAll(x => x.ReciboId == int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()))[0];

                lbl_FechaCobro.Text = seleccionado.Fecha.ToString();
                lblMedioPago.Text = DB.MedioPago.Find(seleccionado.MedioPagoId).Nombre;
                gbLabels.Visible = true;
            }

        }
    }
}
