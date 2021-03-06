//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HappyTourManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal PersonCount { get; set; }
        public decimal TotalSum { get; set; }
        public string IsLoyalty { get; set; }
        public string IsPayed { get; set; }
        public string IsCancelled { get; set; }
        public int TourID { get; set; }
        public int CustomerID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
