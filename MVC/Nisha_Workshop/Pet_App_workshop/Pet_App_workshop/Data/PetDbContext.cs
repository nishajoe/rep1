using Microsoft.EntityFrameworkCore;
using Pet_App_workshop.Models;

namespace Pet_App_workshop.Data;

public class PetDbContext:DbContext
{
    public PetDbContext(DbContextOptions<PetDbContext> options):base(options) { }

    public DbSet<Pet> Pets { get; set; }
}
