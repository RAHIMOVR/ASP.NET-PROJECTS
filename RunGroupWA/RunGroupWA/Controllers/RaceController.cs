using Microsoft.AspNetCore.Mvc;
using RunGroupWA.Data;
using RunGroupWA.Models;

namespace RunGroupWA.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDBContext _context;
        public RaceController(ApplicationDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList(); 
            return View(races);
        }
    }
}
