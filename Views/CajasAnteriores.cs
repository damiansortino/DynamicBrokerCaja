using DynamicBrokerCaja.Models;
using DynamicBrokerCaja.Models.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class CajasAnteriores : Form
    {
        public CajasAnteriores()
        {
            InitializeComponent();
        }

        private void CajasAnteriores_Load(object sender, EventArgs e)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                List<Caja_DGV> listamensual = new List<Caja_DGV>();
                foreach (Caja item in DB.Caja.ToList().FindAll(x => x.FechaBaja == null
                && x.FechaHoraCierre >= DateTime.Now.AddDays(-25)))
                {
                    listamensual.Add(new Caja_DGV(item));
                }

                dgv_Cajas.DataSource = null;

                dgv_Cajas.DataSource = listamensual.ToList();
                dgv_Cajas.Columns[5].Visible = false;
            }
        }
    }
}
