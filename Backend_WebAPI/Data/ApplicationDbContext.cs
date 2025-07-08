using Backend_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> employees { get; set; }
    }
}
