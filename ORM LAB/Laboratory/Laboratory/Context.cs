using Microsoft.EntityFrameworkCore;

namespace Laboratory
{
    public class Context: DbContext
    {
        public DbSet<Company> Companies { get; set; }
        
        public DbSet<Employee> Employees { get; set; } 
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SalaryDB;Trusted_Connection=True;");
        }
    }
}