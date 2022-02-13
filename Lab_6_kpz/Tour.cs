namespace Lab_6_kpz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            MM_Tours_Clients = new HashSet<MM_Tours_Clients>();
            Tours_Entertainments = new HashSet<Tours_Entertainments>();
            Workers_Tours = new HashSet<Workers_Tours>();
        }

        [Key]
        public int ID_tour { get; set; }

        public bool Food { get; set; }

        public int Cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_end { get; set; }

        public int ID_dwelling { get; set; }

        public DateTime? Date_order { get; set; }

        public bool? Pet { get; set; }

        public bool? Smoking { get; set; }

        public virtual Dwelling Dwelling { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MM_Tours_Clients> MM_Tours_Clients { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tours_Entertainments> Tours_Entertainments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Workers_Tours> Workers_Tours { get; set; }
    }
}
