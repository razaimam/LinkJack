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
    
    public partial class ShipmentAdress
    {
        public string shipmentId { get; set; }
        public string addressLine { get; set; }
        public string houseNumber { get; set; }
        public string area { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string pincode { get; set; }
        public string orderId { get; set; }
    
        public virtual OrderHeader OrderHeader { get; set; }
    }
}