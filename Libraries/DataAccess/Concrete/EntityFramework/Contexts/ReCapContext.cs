﻿using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class ReCapContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database=rentaldb; Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder.UseLoggerFactory(CustomerLoggerFactory));
        }
        public static readonly ILoggerFactory CustomerLoggerFactory
         = LoggerFactory.Create(builder =>
         {
             builder
                 .AddFilter((category, level) =>
                     category == DbLoggerCategory.Database.Command.Name
                     && level == LogLevel.Information)
                 .AddDebug();
         });

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(p => p.HasKey(x => x.UserId));
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CarCreditScore> CarCreditScores { get; set; }
        public DbSet<CustomerCreditCard> CustomerCreditCards { get; set; }
        public DbSet<GearType> GearTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
    }
}