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
    
    public partial class Invoice
    {
        public string id { get; set; }
        public string orderId { get; set; }
        public string invoicePath { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
    
        public virtual OrderHeader OrderHeader { get; set; }
    }
}