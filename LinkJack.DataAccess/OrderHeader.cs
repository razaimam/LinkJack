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
    
    public partial class OrderHeader
    {
        public OrderHeader()
        {
            this.Invoices = new HashSet<Invoice>();
            this.OrderLines = new HashSet<OrderLine>();
            this.OrderStatus = new HashSet<OrderStatu>();
            this.Payments = new HashSet<Payment>();
            this.ShipmentAdresses = new HashSet<ShipmentAdress>();
        }
    
        public int orderId { get; set; }
        public string orderType { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<int> customerId { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<System.DateTime> completedDate { get; set; }
        public Nullable<double> discout { get; set; }
        public Nullable<int> userId { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
        public virtual ICollection<OrderStatu> OrderStatus { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<ShipmentAdress> ShipmentAdresses { get; set; }
    }
}
