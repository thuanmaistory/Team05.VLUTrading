//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEP_Demo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rating
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int UserRating { get; set; }
        public int RateValue { get; set; }
        public string Comment { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual User User { get; set; }
    }
}