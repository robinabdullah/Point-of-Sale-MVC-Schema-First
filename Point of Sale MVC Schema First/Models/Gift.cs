//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Point_of_Sale_MVC_Schema_First.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gift
    {
        public string Barcode { get; set; }
        public int Customer_Sale_ID { get; set; }
        public string SL { get; set; }
        public string Gift_Code { get; set; }
        public Nullable<int> Discount_Price { get; set; }
    
        public virtual Barcode Barcode1 { get; set; }
        public virtual Customer_Sale Customer_Sale { get; set; }
    }
}
