using Microsoft.AspNetCore.Mvc;
using RoyalPawsProcuts.Data;

namespace RoyalPawsProcuts.Controllers
{
    public class OwnerController : Controller
    {
        // Shared db conn available to all controller methods
        private readonly ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
