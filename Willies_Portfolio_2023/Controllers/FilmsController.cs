using Microsoft.AspNetCore.Mvc;
using Willies_Portfolio_2023.Data;

namespace Willies_Portfolio_2023.Controllers
{
    public class FilmsController : Controller
    {
        private readonly AppDbContext _context;

        public FilmsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Films.ToList();
            return View(data);
        }
    }
}
