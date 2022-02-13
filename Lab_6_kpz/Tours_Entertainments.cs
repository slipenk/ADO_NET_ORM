namespace Lab_6_kpz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tours_Entertainments
    {
        public int ID_tour { get; set; }

        public int ID_Entertainment { get; set; }

        public int ID { get; set; }

        public virtual Entertainment Entertainment { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
