using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponRental.Domain.Models
{
    public class Member : DomainObject
    {
        public string No_KTP { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; } 
    }
}
