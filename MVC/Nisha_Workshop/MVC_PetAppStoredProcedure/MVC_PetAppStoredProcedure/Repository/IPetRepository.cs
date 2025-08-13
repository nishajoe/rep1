using MVC_PetAppStoredProcedure.Models;

namespace MVC_PetAppStoredProcedure.Repository
{
    public interface IPetRepository
    {
        public Task AddPetAsync(Pet p);
        public Task<List<Pet>> GetPetAsync();
        public Task<IEnumerable<PetCategory>> GetCategoriesAsync();
    }
}
