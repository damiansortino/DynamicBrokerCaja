//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamicBrokerCaja.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Recibo = new HashSet<Recibo>();
        }
    
        public int Id { get; set; }
        public string ApellidoNombre { get; set; }
        public string DNI { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public int EstadoCivilId { get; set; }
        public string email { get; set; }
        public string ActividadComercial { get; set; }
        public int CondFiscalId { get; set; }
        public string CUITCUIL { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<System.DateTime> fechabaja { get; set; }
    
        public virtual CondFiscal CondFiscal { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo { get; set; }
    }
}
