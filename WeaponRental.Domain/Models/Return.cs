using System;
using System.Collections.Generic;
using System.Text;

namespace WeaponRental.Domain.Models
{
    public class Return : DomainObject
    {
        public int Id_Borrow { get; set; }
        public int Id_Member { get; set; }
        public int Id_Officer { get; set; }
        public string Id_Weapon { get; set; }
        public DateTime Return_Date { get; set; }
    }
}
