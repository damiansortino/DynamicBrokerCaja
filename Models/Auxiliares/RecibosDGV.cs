using System;

namespace DynamicBrokerCaja.Models.Auxiliares
{
    class RecibosDGV
    {
        public int Id { get; set; }
        public int RamaId { get; set; }
        public string Poliza { get; set; }
        public string Endoso { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public string Cuota { get; set; }
        public Nullable<System.DateTime> Vencimiento { get; set; }
        public Nullable<System.DateTime> ProxVto { get; set; }
        public Nullable<System.DateTime> VtoConvenio { get; set; }
        public string CodigoBarra { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }

        public RecibosDGV(Recibo v)
        {
            Id = v.Id;
            RamaId = v.RamaId;
            Poliza = v.Poliza;
            Endoso = v.Endoso;
            Importe = v.Importe;
            Cuota = v.Cuota;
            Vencimiento = v.Vencimiento;
            ProxVto = v.ProxVto;
            VtoConvenio = v.VtoConvenio;
            CodigoBarra = v.CodigoBarra;
            ClienteId = v.ClienteId;
            FechaBaja = v.FechaBaja;
        }
    }


}
