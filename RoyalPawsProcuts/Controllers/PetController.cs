using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoyalPawsProcuts.Data;
using RoyalPawsProcuts.Models;

namespace RoyalPawsProcuts.Controllers
{
    public class PetController : Controller
    {
        // Shared db conn available to all controller methods
        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pets = _context.Pets.Include(pets => pets.Owner).ToList();
            return View(pets);
        }

        // create GET
        // to display a form to create new data
        public IActionResult Create()
        {
            ViewBag.OwnerId = new SelectList(_context.Owners, "OwnerId", "FullName");
            return View();
        }

        // create POST
        // to process the form and add new data
        // use [HttpPost] and bind
        [HttpPost]
        public IActionResult Create([Bind("PetName, Species, Breed, OwnerId")] Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return View(pet);
            }

            _context.Pets.Add(pet);
            _context.SaveChanges();
            // redirect to index
            return RedirectToAction("Index");
        }

        // edit GET
        // to display a form to edit existing data
        public IActionResult Edit(int id)
        {
            var pet = _context.Pets.Find(id);
            if (pet == null)
                return NotFound();

            // fetch owners for dropdown
            ViewBag.OwnerId = new SelectList(_context.Owners.OrderBy(o => o.FullName).ToList(), "OwnerId", "FullName", pet.OwnerId);

            return View(pet);
        }

        // edit POST
        // to process the form and update existing data
        // use [HttpPost] and bind
        [HttpPost]
        public IActionResult Edit([Bind("PetId, PetName, Species, Breed, OwnerId")] Pet pet)
        {
            if (!ModelState.IsValid)
            {
                return View(pet);
            }

            _context.Pets.Update(pet);
            _context.SaveChanges();
            // redirect to index
            return RedirectToAction("Index");
        }

            // delete GET
            // show confirmart alert then remove the selected record
            public IActionResult Delete(int id)
        {
            var pet = _context.Pets.Find(id);
            if (pet == null)
                return NotFound();

            _context.Pets.Remove(pet);
            _context.SaveChanges();
            // redirect to index
            return RedirectToAction("Index");
        }

    }
    }
