//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HorizonDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aircraft
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aircraft()
        {
            this.Flights = new HashSet<Flight>();
        }
    
        public int aircraft_id { get; set; }
        public string producer { get; set; }
        public int model_num { get; set; }
        public int seat_actual { get; set; }
        public int seat_max { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
