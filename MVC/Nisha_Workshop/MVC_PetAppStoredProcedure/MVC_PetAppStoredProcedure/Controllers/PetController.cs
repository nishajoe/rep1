using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_PetAppStoredProcedure.Models;
using MVC_PetAppStoredProcedure.Repository;
using System.Diagnostics;

namespace MVC_PetAppStoredProcedure.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetRepository _repo;

        public PetController(IPetRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            var pets = await _repo.GetPetAsync();
            return View(pets);



        }
        public async Task<IActionResult> CreateAsync()
        {
            ViewBag.Categories = new SelectList(await _repo.GetCategoriesAsync(), "Id", "Name");
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Pet pet)
        {
            if (ModelState.IsValid)
            {
                await _repo.AddPetAsync(pet);
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categories = new SelectList(await _repo.GetCategoriesAsync(), "Id", "Name", pet.Category);
            return View(pet);
        }


    }
}
