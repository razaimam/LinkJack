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
    
    public partial class Inventory
    {
        public string id { get; set; }
        public string productId { get; set; }
        public Nullable<int> number { get; set; }
        public Nullable<System.DateTime> insertDate { get; set; }
        public Nullable<System.DateTime> updateDate { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
