using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponRental.Domain.Models
{
    public class Weapon : DomainObject
    {
        public string Brand { get; set; }
        public string Amunition { get; set; }
        public int Total_Weapon { get; set; }
    }
}
