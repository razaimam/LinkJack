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
    
    public partial class UserDocument
    {
        public string id { get; set; }
        public string userId { get; set; }
        public string documentName { get; set; }
        public string documentPath { get; set; }
        public Nullable<bool> isVerfied { get; set; }
        public Nullable<System.DateTime> verificationDate { get; set; }
        public Nullable<int> docVerficationMsgId { get; set; }
        public string documentType { get; set; }
    
        public virtual User User { get; set; }
        public virtual VerificationMsg VerificationMsg { get; set; }
    }
}