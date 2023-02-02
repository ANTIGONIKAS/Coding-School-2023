
using Model;
using EF_Session_16.Orm.Configurations;
using Microsoft.EntityFrameworkCore;
using Orm.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Orm.Context
{
    public class  PetShopContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetFood> PetFoods { get; set; }
        public DbSet<MonthlyLedger> MonthlyLedgers { get; set; }
        public DbSet<PetReport> PetReports { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionLine> TransactionsLines { get; set; }
      
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new PetConfiguration());
            modelBuilder.ApplyConfiguration(new PetFoodConfiguration());
            modelBuilder.ApplyConfiguration(new MonthlyLedgerConfiguration());
            modelBuilder.ApplyConfiguration(new PetReportConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionLineConfiguration());


            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {     optionsBuilder.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; initial catalog = PetShopDB; integrated security = SSPI; TrustServerCertificate = True");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
