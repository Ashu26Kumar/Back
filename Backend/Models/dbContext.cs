using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models.manager
{
    public class dbContext:DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<state> states { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Broker>()
                .Property(c => c.name)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Broker>()
                .Property(c => c.email)
                .HasColumnType("varchar(50)")
                .IsRequired();
            modelBuilder.Entity<Broker>()
                .Property(c => c.city)
                .HasColumnType("varchar(100)")
                .IsRequired();
            modelBuilder.Entity<Broker>()
                .Property(c => c.state)
                .IsRequired()
                .HasColumnType("varchar(50)");
            modelBuilder.Entity<Broker>()
                .Property(c => c.commission)
                .IsRequired();
            modelBuilder.Entity<Broker>()
                .Property(c => c.address1)
                .IsRequired()
                .HasColumnType("varchar(100)");
            modelBuilder.Entity<Broker>()
                .Property(c => c.address2)
                .HasColumnType("varchar(100)");
            modelBuilder.Entity<Broker>()
                .Property(c => c.isActive)
                .IsRequired();
            modelBuilder.Entity<state>()
                .Property(c => c.stateName)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
