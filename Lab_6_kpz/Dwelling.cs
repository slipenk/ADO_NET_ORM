namespace Lab_6_kpz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dwelling")]
    public partial class Dwelling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dwelling()
        {
            Tours = new HashSet<Tour>();
        }

        [Key]
        public int ID_dwelling { get; set; }

        public short Number_of_beds { get; set; }

        public short Number_of_rooms { get; set; }

        public short Number_of_floors { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
