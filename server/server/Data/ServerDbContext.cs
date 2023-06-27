using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class ServerDbContext : DbContext
    {
        public ServerDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
