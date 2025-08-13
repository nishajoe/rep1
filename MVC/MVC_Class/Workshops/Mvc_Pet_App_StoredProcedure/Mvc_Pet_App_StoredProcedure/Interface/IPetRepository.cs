using Mvc_Pet_App_StoredProcedure.Models;
using Mvc_Pet_App_StoredProcedure.Repository;

namespace Mvc_Pet_App_StoredProcedure.Interface
{
    public interface IPetRepository
    {
        public Task AddPetAsync(Pet pet);
        public Task<List<Pet>> GetPetsAsync();
        public Task<IEnumerable<PetCategory>> GetCategoriesAsync();
    }
}
