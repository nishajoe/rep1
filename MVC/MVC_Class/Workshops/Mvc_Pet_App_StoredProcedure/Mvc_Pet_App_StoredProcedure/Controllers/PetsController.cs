using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Mvc_Pet_App_StoredProcedure.Interface;
using Mvc_Pet_App_StoredProcedure.Models;
using Mvc_Pet_App_StoredProcedure.Repository;

namespace Mvc_Pet_App_StoredProcedure.Controllers
{
    public class PetsController : Controller
    {
        private readonly IPetRepository petRepository;

        public PetsController(IPetRepository _petRepository)
        {
            petRepository = _petRepository;
        }
        public async Task<IActionResult> Index()
        {
            var pets = await petRepository.GetPetsAsync();
            return View(pets);
            
       }
        public async Task<IActionResult> Create()
        {
            ViewBag.Categories = new SelectList(await petRepository.GetCategoriesAsync(), "Id", "Name");
            return View();
          
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                await petRepository.AddPetAsync(pet);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(await petRepository.GetCategoriesAsync(), "Id", "Name", pet.Category);
            return View(pet);
        }
    }
}
