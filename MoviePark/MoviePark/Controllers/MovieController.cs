using Microsoft.AspNetCore.Mvc;
using MoviePark.Data;
using MoviePark.Models;

namespace MoviePark.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
