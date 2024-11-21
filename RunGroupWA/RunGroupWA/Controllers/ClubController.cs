﻿using Microsoft.AspNetCore.Mvc;
using RunGroupWA.Data;
using RunGroupWA.Models;

namespace RunGroupWA.Controllers
{
    public class ClubController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ClubController(ApplicationDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Club> clubs = _context.Clubs.ToList();
            return View(clubs);
        }

        public IActionResult Detail(int id)
        {
            Club club = _context.Clubs.FirstOrDefault(c => c.Id == id);
            return View(club); 
        }
    }
}
