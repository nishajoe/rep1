using Microsoft.EntityFrameworkCore;

namespace Userdto_LoginRegister.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
      
        public DbSet<User> Users { get; set; }
    }
}
