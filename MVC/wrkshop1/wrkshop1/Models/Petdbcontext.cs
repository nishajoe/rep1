using Microsoft.EntityFrameworkCore;

namespace wrkshop1.Models
{
    public class Petdbcontext : DbContext

    {
        public Petdbcontext(DbContextOptions<Petdbcontext> options) : base(options) { }

        public DbSet<Pet> pets {  get; set; }
        
    }
}
