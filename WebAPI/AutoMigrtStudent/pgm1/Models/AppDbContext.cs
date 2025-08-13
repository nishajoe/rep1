using Microsoft.EntityFrameworkCore;

namespace pgm1.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
