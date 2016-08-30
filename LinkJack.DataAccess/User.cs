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
    
    public partial class User
    {
        public User()
        {
            this.Customers = new HashSet<Customer>();
            this.UserDocuments = new HashSet<UserDocument>();
            this.Wishlists = new HashSet<Wishlist>();
        }
    
        public string userId { get; set; }
        public string password { get; set; }
        public string roleId { get; set; }
        public string email { get; set; }
        public Nullable<int> statusId { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> lastLogIn { get; set; }
        public Nullable<int> attempts { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual Role Role { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<UserDocument> UserDocuments { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
    }
}
