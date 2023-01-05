using System;

namespace DynamicBrokerCaja.Models.Auxiliares
{
    class Caja_DGV
    {
        public int Id { get; set; }
        public System.DateTime FechaHoraApertura { get; set; }
        public Nullable<System.DateTime> FechaHoraCierre { get; set; }
        public Nullable<decimal> Apertura { get; set; }
        public Nullable<decimal> Cierre { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }

        public Caja_DGV(Caja m)
        {
            m.Id = Id;
            m.FechaHoraApertura = FechaHoraApertura;
            m.FechaHoraCierre = FechaHoraCierre;
            m.Apertura = Apertura;
            m.Cierre = Cierre;
            m.FechaBaja = FechaBaja;
        }
    }
}
