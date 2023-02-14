using Microsoft.AspNetCore.Mvc;
using Willies_Portfolio_2023.Data;

namespace Willies_Portfolio_2023.Controllers
{
    public class StillsController : Controller
    {
        private readonly AppDbContext _context;

        public StillsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Stills.ToList();
            return View(data);
        }
    }
}
