using Microsoft.AspNetCore.Mvc;
using RoyalPawsProcuts.Data;

namespace RoyalPawsProcuts.Controllers
{
    public class StoreController : Controller
    {
        // Shared db conn available to all controller methods
        private readonly ApplicationDbContext _context;

        // index to display a list of data
        public IActionResult Index()
        {
            return View();
        }

    }
}
