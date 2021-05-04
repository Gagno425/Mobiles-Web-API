using Microsoft.EntityFrameworkCore;
using Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mobile.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
        : base(options) 
        {

        }


        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Phone> Mobiles { get; set; }
    }
}
