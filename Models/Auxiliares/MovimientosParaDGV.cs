using System;

namespace DynamicBrokerCaja.Models.Auxiliares
{
    class MovimientosParaDGV
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal Importe { get; set; }
        public string Cuota { get; set; }
        public string MedioPago { get; set; }
        public string TipoMov { get; set; }

        public MovimientosParaDGV(Movimiento mov)
        {
            Movimiento movi = mov;
            using (DynamicBrokerEntities DB = new DynamicBrokerEntities())
            {
                movi.Caja = DB.Caja.Find(mov.CajaId);
                movi.TipoMovimientoCaja = DB.TipoMovimientoCaja.Find(mov.TipoMovId);
                movi.MedioPago = DB.MedioPago.Find(mov.MedioPagoId);
                Recibo recibo = DB.Recibo.Find(movi.ReciboId);
                movi.Recibo = recibo;
            }

            Fecha = mov.Fecha;
            if (mov.TipoMovId == 8)
            {
                Cliente = "";
                Cuota = movi.Recibo.Cuota;
            }
            else
            {
                if (mov.TipoMovId == 9)
                {
                    Cliente = "";
                }
            }
            TipoMov = movi.TipoMovimientoCaja.Nombre;
            Importe = mov.Importe;
            MedioPago = movi.MedioPago.Nombre;

        }
    }
}
