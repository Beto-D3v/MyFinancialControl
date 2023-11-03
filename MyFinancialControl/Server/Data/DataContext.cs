using Microsoft.EntityFrameworkCore;
using MyFinancialControl.Server.Models;

namespace MyFinancialControl.Server.Data
{
    public class DataContext : DbContext
    {
        public DbSet<ExpenseModel> Expenses { get; set; }

        public DataContext(DbContextOptions options) : base(options) 
        { 
            
        }
        protected DataContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseModel>().HasData(
                new ExpenseModel(Guid.NewGuid(),"Conta de luz", "Roberto", "Conta de luz", 270.00, DateTime.Now),
                new ExpenseModel(Guid.NewGuid(),"Madrid", "Roberto", "Mercado", 300.00, DateTime.Now),
                new ExpenseModel(Guid.NewGuid(), "Padaria", "Roberto", "Alimentação", 40.00, DateTime.Now));

        }

    }
}
