using EpsilonLocal.DAL;
using EpsilonLocal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EpsilonLocal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EtReceivableController : Controller
    {
        private readonly AppDbContext _context;
        public EtReceivableController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.EtReceivables.Where(c => c.IsDeleted == false).ToListAsync());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EtReceivable epExpense)
        {
            if (!ModelState.IsValid) return View();
            epExpense.IsDeleted = false;
            await _context.EtReceivables.AddAsync(epExpense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            EtReceivable category = await _context.EtReceivables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(EtReceivable epExpense)
        {
            if (!ModelState.IsValid) return View(epExpense);

            EtReceivable dbCategory = await _context.EtReceivables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == epExpense.Id);
            if (dbCategory == null) return NotFound();
            dbCategory.Id = epExpense.Id;
            dbCategory.Edv = epExpense.Edv;
            dbCategory.IsDeleted = epExpense.IsDeleted;
            dbCategory.Date = epExpense.Date;
            dbCategory.Description = epExpense.Description;
            dbCategory.Amount = epExpense.Amount;
            dbCategory.Client = epExpense.Client;
            dbCategory.Month = epExpense.Month;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            EtReceivable epExpense = await _context.EtReceivables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (epExpense == null) return NotFound();
            return View(epExpense);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            EtReceivable epExpense = await _context.EtReceivables.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (epExpense == null) return NotFound();
            //_context.Categories.Remove(category);
            epExpense.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
