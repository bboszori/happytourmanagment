//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int PersonID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public decimal Phone { get; set; }
        public string AddressCity { get; set; }
        public string AddressZip { get; set; }
        public string AddressFree { get; set; }
        public string AddressCountry { get; set; }
        public string IDType { get; set; }
        public decimal IDNumber { get; set; }
        public System.DateTime ValidTo { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Tourguide Tourguide { get; set; }
    }
}
