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
    
    public partial class Workers_Tours
    {
        public int ID_1 { get; set; }
        public int ID_worker { get; set; }
        public int ID_tour { get; set; }
    
        public virtual Tour Tour { get; set; }
        public virtual Worker Worker { get; set; }
    }
}