using Microsoft.EntityFrameworkCore;

namespace WebApp_AutoController_CrudOperation.Models
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; }
    }
}
