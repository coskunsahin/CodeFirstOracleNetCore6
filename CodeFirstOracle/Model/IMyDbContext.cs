using Microsoft.EntityFrameworkCore;

namespace CodeFirstOracle.Model
{
    public interface IMyDbContext
    {
        DbSet<Employee> Employees { get; set; }
    }
    public class MyDbContext : DbContext, IMyDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
