using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MVC_PetAppStoredProcedure.Models;

namespace MVC_PetAppStoredProcedure.Repository
{
    public class PetRepository:IPetRepository
    {
        private readonly MvcPetDbContext _dbContext;

        public PetRepository(MvcPetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddPetAsync(Pet p)
        {
            var nameParam = new SqlParameter("@Name", p.Name);
            var ageParam = new SqlParameter("@Age", p.Age);
            var locationParam = new SqlParameter("@Loc", p.Location);
            var CategoryParam = new SqlParameter("@Catgry", p.Category);

            await _dbContext.Database.ExecuteSqlRawAsync("EXEC AddPet @Name, @Age, @Loc, @Catgry", nameParam, ageParam, locationParam, CategoryParam);

        }
        public async Task<List<Pet>> GetPetAsync()
        {

            var Pet = await _dbContext.Pets.FromSqlRaw("EXEC GetPets").ToListAsync();
            return Pet;
        }
        public async Task<IEnumerable<PetCategory>> GetCategoriesAsync()
        {
            return await _dbContext.PetCategories.ToListAsync();
        }
    }
}
