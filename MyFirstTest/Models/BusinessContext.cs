using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyFirstTest.Models
{
    public class BusinessContext:DbContext
    {
        public DbSet<Customer> Custumers { get; set; }
        public DbSet<Founder> Founders { get; set; }

        public BusinessContext(DbContextOptions<BusinessContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
