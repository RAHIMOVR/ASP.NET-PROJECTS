using EpsilonLocal.DAL;
using EpsilonLocal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EpsilonLocal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EpPayableController : Controller
    {
        private readonly AppDbContext _context;
        public EpPayableController(AppDbContext context)
        {
            _context = context; 
        }
        public async  Task<IActionResult> Index()
        {
            return View(await _context.EpPayables.Where(c => c.IsDeleted == false).ToListAsync());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EpPayable epPayable)
        {
            epPayable.IsDeleted = false;
            await _context.EpPayables.AddAsync(epPayable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            EpPayable category = await _context.EpPayables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(EpPayable epPayable)
        {
            if (!ModelState.IsValid) return View(epPayable);

            EpPayable dbCategory = await _context.EpPayables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == epPayable.Id);
            if (dbCategory == null) return NotFound();
            dbCategory.Id = epPayable.Id;
            dbCategory.Description = epPayable.Description;
            dbCategory.IsDeleted = epPayable.IsDeleted;
            dbCategory.Date = epPayable.Date;
            dbCategory.Contractor = epPayable.Contractor;
            dbCategory.Amount = epPayable.Amount;
            dbCategory.Month = epPayable.Month;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            EpPayable epPayable = await _context.EpPayables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (epPayable == null) return NotFound();
            return View(epPayable);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            EpPayable epPayable = await _context.EpPayables.Where(c => c.IsDeleted == false).FirstOrDefaultAsync(c => c.Id == id);
            if (epPayable == null) return NotFound();
            //_context.Categories.Remove(category);
            epPayable.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
