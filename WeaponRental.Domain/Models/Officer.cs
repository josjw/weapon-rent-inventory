using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponRental.Domain.Models
{
    public class Officer : DomainObject
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
