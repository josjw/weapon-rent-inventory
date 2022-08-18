using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WeaponRental.Domain.Models;

namespace WeaponRental.EntityFramework
{
    public class WeaponRentalDbContext : DbContext
    {
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Officer> Officers { get; set; }
        public DbSet<Return> Returns { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<WeaponType> WeaponTypes { get; set; }
        public WeaponRentalDbContext(DbContextOptions options) : base(options) { }  
    }
}
