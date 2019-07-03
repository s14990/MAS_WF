using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_PROJECT_WF.Models
{
    class MyContext : DbContext
    {


        public DbSet<Batch> Batches { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Practise> Practises { get; set; }

        public DbSet<Wholesaler> Wholesalers { get; set; }

        public DbSet<Wholesale_Purchase> Wholesale_Purchases { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Worker> Workers { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MasMain;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Assistant>();
            builder.Entity<Pharmacist>();

            base.OnModelCreating(builder);

        }
    }
}
