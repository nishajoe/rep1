using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pet_App_workshop.Data;
using Pet_App_workshop.Models;

namespace Pet_App_workshop.Controllers
{
    public class PetController : Controller
    {
        private readonly PetDbContext _context;

        public PetController(PetDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Pets.ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PetDto petdto)
        {
            if (ModelState.IsValid)
            {
                var pet = new Pet
                {
                    Id = Guid.NewGuid(),
                    Name = petdto.Name,
                    Age = petdto.Age,
                    Gender = petdto.Gender,
                    Discription = petdto.Discription,
                    Location = petdto.Location
                };

                //if (petdto.Image != null && petdto.Image.Length > 0)
                //{
                //    using (var stream = new MemoryStream())
                //    {
                //        petdto.Image.CopyTo(stream);
                //        pet.Image = Convert.ToBase64String(stream.ToArray());
                //    }
                //}
                _context.Pets.Add(pet);
                _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(petdto);
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            var dto = new PetDto
            {
                Name = pet.Name,
                Age = pet.Age,
                Gender = pet.Gender,
                Discription = pet.Discription,
                Location = pet.Location
            };
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, PetDto dto)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var pet = await _context.Pets.FindAsync(id);
                if (pet == null)
                {
                    return NotFound();
                }
                pet.Name = dto.Name;
                pet.Age = dto.Age;
                pet.Gender = dto.Gender;
                pet.Discription = dto.Discription;
                pet.Location = dto.Location;
                //if (dto.Image != null && dto.Image.Length > 0)
                //{
                //    using (var stream = new MemoryStream())
                //    {
                //        await dto.Image.CopyToAsync(stream);
                //        pet.Image = Convert.ToBase64String(stream.ToArray());
                //    }
                //}
                try
                {
                    _context.Update(pet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PetExists(pet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }

            return View(dto);
        }


        private bool PetExists(Guid id)
        {
            return _context.Pets.Any(e => e.Id == id);
        }


        public async Task<IActionResult> Delete(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }


        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}