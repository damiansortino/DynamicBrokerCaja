using DynamicBrokerCaja.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class TipoMovCaja_ABM : Form
    {
        public TipoMovCaja_ABM()
        {
            InitializeComponent();
        }

        private void TipoMovCaja_ABM_Load(object sender, EventArgs e)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                List<TipoMovimientoCaja> tipos = DB.TipoMovimientoCaja.ToList().FindAll(x => x.FechaBaja == null);
                //dataGridView1.dat
            }
        }
    }
}
