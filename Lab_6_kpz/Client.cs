namespace Lab_6_kpz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            MM_Tours_Clients = new HashSet<MM_Tours_Clients>();
        }

        [Key]
        public int ID_client { get; set; }

        [Required]
        [StringLength(100)]
        public string Surname { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string MIddle_name { get; set; }

        [Required]
        [StringLength(100)]
        public string Phone_number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date_birth { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string HomeTown { get; set; }

        [Column(TypeName = "date")]
        public DateTime Registration_date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MM_Tours_Clients> MM_Tours_Clients { get; set; }
    }
}
