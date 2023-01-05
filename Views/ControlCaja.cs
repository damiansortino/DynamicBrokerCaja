using DynamicBrokerCaja.Models;
using DynamicBrokerCaja.Models.Auxiliares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DynamicBrokerCaja.Views
{
    public partial class ControlCaja : Form
    {
        public ControlCaja()
        {
            InitializeComponent();
        }

        private void Caja_Load(object sender, EventArgs e)
        {
            if (ExisteCajaAbierta())
            {
                LlenarDGVMovimientos();
                lblEfectivoCaja.Text = "Efectivo en Caja $ " + EfectivoCajaActual();
            }
            else
            {
                lblEfectivoCaja.Text = "";
            }
        }

        private void LlenarDGVMovimientos()
        {
            dgvMovimientos.DataSource = null;

            if (!ComprobarCajaAnteriorSinCerrar())
            {

                if (ExisteCajaAbierta())
                {
                    dgvMovimientos.DataSource = MovimientosDGV(MovimientosCaja(CajaActual().Id));
                    lblEfectivoCaja.Text = "Efectivo en Caja $ " + EfectivoCajaActual().ToString();
                }

            }
            else
            {
                MessageBox.Show("Advertencia, La caja anterior todavía no ha sido cerrada");
                lblEfectivoCaja.Text = "";
            }
        }

        private decimal EfectivoCajaActual()
        {
            decimal cajaactual = 0;
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                Caja actual = CajaActual();
                List<Movimiento> movimientos = DB.Movimiento.ToList().FindAll(x => x.CajaId == actual.Id
                && x.MedioPagoId == 1).FindAll(x => x.FechaBaja == null);
                foreach (Movimiento item in movimientos)
                {
                    cajaactual = cajaactual + item.Importe;
                }
            }
            return cajaactual;
        }

        private List<MovimientosParaDGV> MovimientosDGV(List<Movimiento> movimientos)
        {
            List<MovimientosParaDGV> formato = new List<MovimientosParaDGV>();

            foreach (Movimiento item in movimientos)
            {
                MovimientosParaDGV nuevo = new MovimientosParaDGV(item);
                formato.Add(nuevo);
            }
            return formato;
        }

        private List<Movimiento> MovimientosCaja(int id)
        {
            List<Movimiento> movimientos = new List<Movimiento>();
            try
            {
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    movimientos = DB.Movimiento.ToList()
                        .FindAll(x => x.CajaId == id && x.MedioPagoId == 1).FindAll(x => x.FechaBaja == null);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en método MovimientosCaja");
            }
            return movimientos;
        }

        private Caja CajaActual()
        {
            Caja enviar = new Caja();
            try
            {
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    enviar = DB.Caja.ToList().Find(x => x.FechaHoraCierre == null);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error en el método CajaActual");
            }
            return enviar;
        }

        private bool ExisteCajaAbierta()
        {
            bool bandera = false;
            try
            {
                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    List<Caja> lista = DB.Caja.ToList().FindAll(x => x.FechaHoraCierre == null);
                    if (lista.Count > 0)
                    {
                        bandera = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error en método ExisteCajaAbierta");
            }
            return bandera;
        }

        private bool ComprobarCajaAnteriorSinCerrar()
        {
            bool bandera = false;
            try
            {

                using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
                {
                    List<Caja> lista = DB.Caja.ToList().FindAll(x => x.FechaHoraCierre == null);
                    foreach (var item in lista)
                    {
                        if (item.FechaHoraApertura.Date != DateTime.Now.Date)
                        {
                            bandera = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Contacte al soporte e informe error Nº 0001");
            }

            return bandera;
        }

        private void btnIniciarCaja_Click(object sender, EventArgs e)
        {
            lblEfectivoCaja.Text = "";
            if (!ComprobarCajaAnteriorSinCerrar() && !ExisteCajaAbierta())
            {
                IniciarCaja iniciar = new IniciarCaja();
                iniciar.MdiParent = ParentForm;
                iniciar.Show();
            }
            else
            {
                MessageBox.Show("Ya existe una caja abierta");
            }
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            lblEfectivoCaja.Text = "";
            if (!ExisteCajaAbierta())
            {
                MessageBox.Show("No hay cajas abiertas");
            }
            else
            {
                CerrarCaja(CajaActual().Id);
            }
        }

        private void CerrarCaja(int id)
        {
            CerrarCajaView vista = new CerrarCajaView(id);
            vista.MdiParent = ParentForm;
            vista.Show();
        }

        private void btnNuevoCobro_Click(object sender, EventArgs e)
        {
            if (ExisteCajaAbierta())
            {
                NuevoCobro nuevo = new NuevoCobro();
                nuevo.MdiParent = ParentForm;
                nuevo.Show();
            }
            else
            {
                MessageBox.Show("Debe iniciar la caja antes de poder realizar un nuevo cobro");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LlenarDGVMovimientos();
        }

        private void btnRetiroCaja_Click(object sender, EventArgs e)
        {
            lblEfectivoCaja.Text = "";
            if (ExisteCajaAbierta())
            {
                RetiroCaja nuevo = new RetiroCaja();
                nuevo.MdiParent = ParentForm;
                nuevo.Show();
            }
            else
            {
                MessageBox.Show("No hay una caja abierta para realizar retiros");
            }
        }

        private void btnOtrosMovimientos_Click(object sender, EventArgs e)
        {
            if (ExisteCajaAbierta())
            {
                lblEfectivoCaja.Text = "";
                OtrosMovimientos form = new OtrosMovimientos();
                form.MdiParent = ParentForm;
                form.Show();
            }
            else
            {
                MessageBox.Show("Error, antes de hacer movimientos debe iniciar caja");
            }

        }

        private void dgvMovimientos_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvMovimientos.SelectedRows.Count > 0) btnDeleteMov.Enabled = true;
        }
        private void btnDeleteMov_Click(object sender, EventArgs e)
        {
            bool iniciocierre = true;
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                if (DB.Movimiento.Find((int)dgvMovimientos.CurrentRow.Cells[0].Value).TipoMovId == 1 || DB.Movimiento.Find((int)dgvMovimientos.CurrentRow.Cells[0].Value).TipoMovId == 2)
                {
                    iniciocierre = true;
                }
                else
                {
                    iniciocierre = false;
                }
            }

            if (!iniciocierre)
            {
                btnDeleteMov.Enabled = false;

                DialogResult result = MessageBox.Show("¿Está Seguro que desea eliminar este movimiento?", "Cancelar", MessageBoxButtons.YesNoCancel);

                switch (result)
                {
                    case DialogResult.Yes:
                        int borrar = (int)dgvMovimientos.CurrentRow.Cells[0].Value;
                        BorrarOperacion(borrar);
                        LlenarDGVMovimientos();
                        MessageBox.Show("Movimiento eliminado exitosamente");

                        break;
                    case DialogResult.No:

                        break;
                    case DialogResult.Cancel:

                        break;
                }

            }
            else
            {
                MessageBox.Show("No se pueden eliminar movimientos de inicio o cierre de caja");
            }

        }

        private void BorrarOperacion(int borrar)
        {
            Recibo borrarrecibo = new Recibo();
            Movimiento borramovimiento = new Movimiento();

            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                borramovimiento = DB.Movimiento.Find(borrar);
                if (borramovimiento.TipoMovId == 8)
                {
                    borrarrecibo = DB.Recibo.Find(borramovimiento.ReciboId);
                    BorrarRecibo(borrarrecibo);
                    BorrarMovimiento(borramovimiento);
                }
                else
                {
                    BorrarMovimiento(borramovimiento);
                }
            }


        }

        private void BorrarMovimiento(Movimiento borramovimiento)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                Movimiento borrar = DB.Movimiento.Find(borramovimiento.Id);
                borrar.FechaBaja = DateTime.Now;
                DB.Entry(borrar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
            }
        }

        private void BorrarRecibo(Recibo borrarrecibo)
        {
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                Recibo borrar = DB.Recibo.Find(borrarrecibo.Id);
                borrar.FechaBaja = DateTime.Now;
                DB.Entry(borrar).State = System.Data.Entity.EntityState.Modified;
                DB.SaveChanges();
            }
        }

        private void ControlCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)49:

                    btnNuevoCobro.PerformClick();
                    e.Handled = true;
                    break;

                case (char)50:
                    btnIniciarCaja.PerformClick();
                    e.Handled = true;
                    break;
                case (char)51:
                    btnCerrarCaja.PerformClick();
                    e.Handled = true;
                    break;
                case (char)52:
                    btnRetiroCaja.PerformClick();
                    e.Handled = true;
                    break;
                case (char)53:
                    btnOtrosMovimientos.PerformClick();
                    e.Handled = true;
                    break;

                default:

                    MessageBox.Show("No hay funcion programada, pruebe con otra opción");
                    e.Handled = true;
                    break;

            }
        }
    }
}
