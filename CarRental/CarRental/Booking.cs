//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRental
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int id { get; set; }
        public string code { get; set; }
        public Nullable<System.DateTime> booking_date { get; set; }
        public Nullable<System.DateTime> return_date { get; set; }
        public Nullable<int> car_id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<decimal> cost { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual Customer Customer { get; set; }
    }
}