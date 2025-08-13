using Microsoft.EntityFrameworkCore;
using Service_Repo_Crud_Manual.Models;

namespace Service_Repo_Crud_Manual.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
