//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_6_DB_first
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dwelling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dwelling()
        {
            this.Tours = new HashSet<Tour>();
        }
    
        public int ID_dwelling { get; set; }
        public short Number_of_beds { get; set; }
        public short Number_of_rooms { get; set; }
        public short Number_of_floors { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
