using HL_NET.Models;
using Microsoft.EntityFrameworkCore;
using HL_NET.Models;

namespace HL_NET.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
