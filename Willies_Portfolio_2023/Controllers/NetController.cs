using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Dynamic;
using Willies_Portfolio_2023.Data;

namespace Willies_Portfolio_2023.Controllers
{
    public class NetController : Controller
    {
        private readonly AppDbContext _context;
        public NetController(AppDbContext context)
        {
            _context= context;
        }
        public IActionResult Index()
        {
            dynamic netdata = new ExpandoObject();
            netdata.NetProject = _context.NetProjects.ToList();
            netdata.NetBreakdownSection = _context.NetProjectsBreakdownSections.ToList();
            netdata.NetDescription = _context.NetProjectsDescriptions.ToList();

            
            return View(netdata);
        }
    }
}
