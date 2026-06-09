using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalPawsProcuts.Data;

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
            return View();
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

        // edit GET
        // to display a form to edit existing data

        // edit POST
        // to process the form and update existing data
        // use [HttpPost] and bind

        // delete GET
        // show confirmart alert then remove the selected record

    }
}
