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
    
    public partial class Worker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Worker()
        {
            this.Workers_Tours = new HashSet<Workers_Tours>();
        }
    
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Middle_name { get; set; }
        public string Phone_number { get; set; }
        public System.DateTime Date_birth { get; set; }
        public int Salary { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int ID_workers { get; set; }
        public Nullable<short> Permissions { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workers_Tours> Workers_Tours { get; set; }
    }
}
