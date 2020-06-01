using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstTest.Models
{
    public class ForTestContext : DbContext
    {
        public DbSet<Customers> Custumers { get; set; }
        public DbSet<Founders> Founders { get; set; }

        public ForTestContext(DbContextOptions<ForTestContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public ForTestContext()
        {
        }
    }
}
