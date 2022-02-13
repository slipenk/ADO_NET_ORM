namespace Lab_6_kpz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Workers_Tours
    {
        [Key]
        public int ID_1 { get; set; }

        public int ID_worker { get; set; }

        public int ID_tour { get; set; }

        public virtual Tour Tour { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
