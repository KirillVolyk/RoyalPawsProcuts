using Microsoft.AspNetCore.Mvc;
using RoyalPawsProcuts.Data;
using RoyalPawsProcuts.Models;

namespace RoyalPawsProcuts.Controllers
{
    public class OwnerController : Controller
    {
        // Shared db conn available to all controller methods
        private readonly ApplicationDbContext _context;

        public OwnerController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var owners = _context.Owners.ToList();
            return View(owners);
        }

        // create GET
        // to display a form to create new data
        public IActionResult Create()
        {
            return View();
        }

        // create POST
        // to process the form and add new data
        // use [HttpPost] and bind
        [HttpPost]
        public IActionResult Create([Bind("OwnerName, Phone, Email")] Owner owner)
        {
            if (!ModelState.IsValid)
                return View(owner);
            
            _context.Owners.Add(owner);
            _context.SaveChanges();
            // redirect to index
            return RedirectToAction("Index");
        }
            
        // edit GET
        // to display a form to edit existing data
        public IActionResult Edit(int id)
        {
            var owner = _context.Owners.Find(id);
            if (owner == null)
                return NotFound();

            return View(owner);
        }

        // edit POST
        // to process the form and update existing data
        // use [HttpPost] and bind
        [HttpPost]
        public IActionResult Edit([Bind("OwnerId, OwnerName, Phone, Email")] Owner owner)
        {
            if (!ModelState.IsValid)
                return View(owner);
            
            _context.Owners.Update(owner);
            _context.SaveChanges();
            // redirect to index
            return RedirectToAction("Index");
        }

        // delete GET
        // show confirmart alert then remove the selected record
        public IActionResult Delete(int id)
        {
            var owner = _context.Owners.Find(id);
            if (owner == null)
                return NotFound();

            _context.Owners.Remove(owner);
            _context.SaveChanges();
            // redirect to index
            return RedirectToAction("Index");
        }

    }
}
