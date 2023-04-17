using System.Xml;

namespace DynamicBrokerCaja.Models.Auxiliares
{
    class Emision_Interfaz
    {
        public string ramo { get; set; }
        public string poliza { get; set; }
        public string endoso { get; set; }
        public string suplemento { get; set; }
        public string fecha_emision { get; set; }
        public string fecha_desde { get; set; }
        public string fecha_hasta { get; set; }
        public string fecha_fin { get; set; }
        public string periodo { get; set; }
        public string codigo_productor { get; set; }
        public string productor_matricula { get; set; }
        public string broker { get; set; }
        public string tipo { get; set; }
        public string motivo { get; set; }
        public string anterior { get; set; }
        public string premio { get; set; }
        public string prima { get; set; }
        public string condiva { get; set; }
        public string cant_cuotas { get; set; }
        public string solicitud { get; set; }
        public string asociada { get; set; }
        public string debito { get; set; }
        public string objeto { get; set; }
        public string tomador_nombre { get; set; }
        public string tomador_dni { get; set; }
        public string tomador_sexo { get; set; }
        public string tomador_cuit { get; set; }
        public string tomador_domicilio { get; set; }
        public string tomador_cp { get; set; }
        public string tomador_ciudad { get; set; }
        public string tomador_provincia { get; set; }
        public string tomador_condiva { get; set; }
        public string bien_asegurado { get; set; }
        public string cobertura { get; set; }

        public Emision_Interfaz(XmlNode nodo)
        {
            ramo = nodo.ChildNodes[0].InnerText;
            poliza = nodo.ChildNodes[1].InnerText;
            endoso = nodo.ChildNodes[2].InnerText;
            suplemento = nodo.ChildNodes[3].InnerText;
            fecha_emision = nodo.ChildNodes[4].InnerText;
            fecha_desde = nodo.ChildNodes[5].InnerText;
            fecha_hasta = nodo.ChildNodes[6].InnerText;
            fecha_fin = nodo.ChildNodes[7].InnerText;
            periodo = nodo.ChildNodes[8].InnerText;
            codigo_productor = nodo.ChildNodes[9].InnerText;
            productor_matricula = nodo.ChildNodes[10].InnerText;
            broker = nodo.ChildNodes[11].InnerText;
            tipo = nodo.ChildNodes[12].InnerText;
            motivo = nodo.ChildNodes[13].InnerText;
            anterior = nodo.ChildNodes[14].InnerText;
            premio = nodo.ChildNodes[16].InnerText;
            prima = nodo.ChildNodes[17].InnerText;
            condiva = nodo.ChildNodes[18].InnerText;
            cant_cuotas = nodo.ChildNodes[32].InnerText;
            solicitud = nodo.ChildNodes[37].InnerText;
            asociada = nodo.ChildNodes[40].InnerText;
            debito = nodo.ChildNodes[42].InnerText;
            objeto = nodo.ChildNodes[44].InnerText;
            tomador_nombre = nodo.ChildNodes[45].ChildNodes[0].InnerText;
            tomador_dni = nodo.ChildNodes[45].ChildNodes[1].InnerText;
            tomador_sexo = nodo.ChildNodes[45].ChildNodes[2].InnerText;
            tomador_cuit = nodo.ChildNodes[45].ChildNodes[3].InnerText;
            tomador_domicilio = nodo.ChildNodes[45].ChildNodes[4].InnerText;
            tomador_cp = nodo.ChildNodes[45].ChildNodes[5].InnerText;
            tomador_ciudad = nodo.ChildNodes[45].ChildNodes[6].InnerText;
            tomador_provincia = nodo.ChildNodes[45].ChildNodes[7].InnerText;
            tomador_condiva = nodo.ChildNodes[45].ChildNodes[8].InnerText;
            bien_asegurado = nodo.ChildNodes[46].ChildNodes[0].ChildNodes[1].InnerText;
            cobertura = nodo.ChildNodes[46].ChildNodes[0].ChildNodes[9].ChildNodes[0].ChildNodes[2].InnerText;

        }
    }
}
