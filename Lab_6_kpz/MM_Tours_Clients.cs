namespace Lab_6_kpz
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MM_Tours_Clients
    {
        public int ID_tours { get; set; }

        public int ID_clients { get; set; }

        public int ID { get; set; }

        public virtual Client Client { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
