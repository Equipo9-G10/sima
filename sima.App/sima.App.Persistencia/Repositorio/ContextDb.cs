using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sima.App.Dominio; 

namespace sima.App.Persistencia
{
    public class ContextDb : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            .HasKey(b => b.EmployeeId)
            .HasName("PrimaryKey_EmployeeId");
        }
            public DbSet<Employee> Employees { get; set; } =null!;
            public DbSet<User> Users { get; set; }= null!;
            public DbSet<Customer> Customers { get; set; } =null!;
            public DbSet<Car> Cars {get; set; }= null!;
            //public DbSet<ServiceRequest> ServiceRequests {get; set; }= null!;
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer($"Server=simadb.ck9lvdmqxsey.us-east-1.rds.amazonaws.com; Database=simadb; User id=admin; Password=@ircrafT89!");
                }
            
            //base.Onconfiguring(optionsBuilder);
            }
        
    }
}

    
