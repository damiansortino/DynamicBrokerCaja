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
    
    public partial class PlanillaRendicionCobranza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanillaRendicionCobranza()
        {
            this.Recibo = new HashSet<Recibo>();
        }
    
        public int Id { get; set; }
        public string NumPlanEmpresa { get; set; }
        public int EstadoPlanillaId { get; set; }
    
        public virtual EstadoPlanillaRendicion EstadoPlanillaRendicion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo { get; set; }
    }
}
