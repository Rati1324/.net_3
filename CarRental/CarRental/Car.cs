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
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.Booking = new HashSet<Booking>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> year { get; set; }
        public Nullable<int> power_hp { get; set; }
        public Nullable<int> transmission_type { get; set; }
        public Nullable<int> fuel_type { get; set; }
        public Nullable<int> body_type { get; set; }
        public Nullable<int> speed { get; set; }
        public Nullable<int> branch { get; set; }
        public Nullable<decimal> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Booking { get; set; }
        public virtual Branch Branch1 { get; set; }
        public virtual CarBodyType CarBodyType { get; set; }
        public virtual FuelType FuelType { get; set; }
        public virtual TransmissionType TransmissionType { get; set; }
    }
}
