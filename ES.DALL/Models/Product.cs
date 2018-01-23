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
    
    public partial class Product
    {
        public int ProductID { get; set; }
        public string ModelCode { get; set; }
        public string Name { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<decimal> OldPrice { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<int> Stock { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string ReturnConditions { get; set; }
        public string InstructionManual { get; set; }
        public string SortOrder { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> SizeID { get; set; }
        public Nullable<int> ColorID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<int> BrandID { get; set; }
        public Nullable<int> AdminID { get; set; }
        public string ImagePath { get; set; }
    
        public virtual Admin Admin { get; set; }
        public virtual Category Category { get; set; }
        public virtual ProductBrand ProductBrand { get; set; }
        public virtual ProductColor ProductColor { get; set; }
        public virtual ProductSize ProductSize { get; set; }
    }
}
