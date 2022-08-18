using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace WeaponRental.EntityFramework
{
    public class WeaponRentalDbContextFactory : IDesignTimeDbContextFactory<WeaponRentalDbContext>
    {
        public WeaponRentalDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<WeaponRentalDbContext>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database = WeaponRentalDB;Trusted_Connection = True;");

            return new WeaponRentalDbContext(options.Options);
            //ganti connection db
        }
    }
}
