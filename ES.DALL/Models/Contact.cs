//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES.DALL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int ContactId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Link { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string Keywords { get; set; }
        public string SortOrder { get; set; }
        public Nullable<bool> Status { get; set; }
    }
}
