using Microsoft.EntityFrameworkCore;
using WebApplicationC__Tut101.Models;

namespace WebApplicationC__Tut101.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}