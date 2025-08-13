using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wrkshop1.Models;

namespace wrkshop1.Controllers
{
    public class PetController : Controller

    {
        public readonly Petdbcontext _context;
        public PetController(Petdbcontext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            
            return View(await _context.pets.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PetDto petDto)
        {
            if (ModelState.IsValid)
            {
                var pet = new Pet
                {
                    Id = Guid.NewGuid(),
                    Name = petDto.Name,
                    Age = petDto.Age,
                    Gender = petDto.Gender,
                    Description = petDto.Description,
                    Location = petDto.Location
                };

                //if (petDto.image != null && petDto.image.Length > 0)
                //{
                //    using (var stream = new MemoryStream())
                //    {
                //        petDto.image.CopyTo(stream);
                //        pet.image = Convert.ToBase64String(stream.ToArray());
                //    }
                //}
                _context.pets.Add(pet);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(petDto);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var pet = await _context.pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            var petDto = new PetDto
            {
                Name = pet.Name,
                Age = pet.Age,
                Gender = pet.Gender,
                Description = pet.Description,
                Location = pet.Location
            };

            return View(petDto);
        }

        [HttpPost]
        
        public async Task<IActionResult> Edit(Guid id, PetDto petDto)
        {
            if (id == Guid.Empty)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var pet = await _context.pets.FindAsync(id);
                if (pet == null)
                {
                    return NotFound();
                }

                pet.Name = petDto.Name;
                pet.Age = petDto.Age;
                pet.Gender = petDto.Gender;
                pet.Description = petDto.Description;
                pet.Location = petDto.Location;

                //if (petDto.image != null && petDto.image.Length > 0)
                //{
                //    using (var stream = new MemoryStream())
                //    {
                //        await petDto.image.CopyToAsync(stream);
                //        pet.image = Convert.ToBase64String(stream.ToArray());
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

            return View(petDto);
        }





        private bool PetExists(Guid id)
        {
            return _context.pets.Any(e => e.Id == id);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var pet = await _context.pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }

            return View(pet);
        }
        
        [HttpPost, ActionName("Delete")]
        
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pet = await _context.pets.FindAsync(id);
            if (pet != null)
            {
                _context.pets.Remove(pet);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
