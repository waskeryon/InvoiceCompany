//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EInvoice
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyTransactions
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> CompanyID { get; set; }
        public Nullable<double> Cash { get; set; }
    
        public virtual Companies Companies { get; set; }
    }
}
