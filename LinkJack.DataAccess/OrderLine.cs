//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinkJack.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLine
    {
        public int orderLineId { get; set; }
        public int orderId { get; set; }
        public Nullable<int> productId { get; set; }
        public string value { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<int> number { get; set; }
        public Nullable<double> discount { get; set; }
        public Nullable<System.DateTime> deliveredDate { get; set; }
    
        public virtual OrderHeader OrderHeader { get; set; }
    }
}
