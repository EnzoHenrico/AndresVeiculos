using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace ProjAPICarro.Data
{
    public class ProjAPICarroContext : DbContext
    {
        public ProjAPICarroContext (DbContextOptions<ProjAPICarroContext> options)
            : base(options)
        {
        }

        public DbSet<Models.Car> Car { get; set; } = default!;
        public DbSet<Models.CarService> CarService { get; set; } = default!;
        public DbSet<Models.Service> Service { get; set; } = default!;
        public DbSet<Models.Purchase> Purchase { get; set; } = default!;
        public DbSet<Models.Address> Address { get; set; } = default!;
        public DbSet<Models.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        
            // Configura a chave primária na entidade raiz Person
            modelBuilder.Entity<Person>()
                .HasKey(p => p.Document);
        }
    }
}
