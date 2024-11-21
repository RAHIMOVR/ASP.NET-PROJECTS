using EpsilonLocal.DAL;
using EpsilonLocal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EpsilonLocal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OpportunityController : Controller
    {

        private readonly AppDbContext _context;
        public OpportunityController(AppDbContext context)
        {
            _context = context;
        }
        public  async  Task<IActionResult> Index()
        {
            return View(await _context.Opportunities.Where(c=>c.IsDeleted==false).ToListAsync());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Opportunity opportunity)
        {
            if (!ModelState.IsValid) return View();
            opportunity.IsDeleted = false;
            await _context.Opportunities.AddAsync(opportunity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Opportunity category = await _context.Opportunities.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Opportunity epExpense)
        {
            if (!ModelState.IsValid) return View(epExpense);
            Opportunity dbCategory = await _context.Opportunities.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == epExpense.Id);
            if (dbCategory == null) return NotFound();
            dbCategory.Id = epExpense.Id;
            dbCategory.ProjectName = epExpense.ProjectName;
            dbCategory.IsDeleted = epExpense.IsDeleted;
            dbCategory.Status = epExpense.Status;
            dbCategory.Deadline= epExpense.Deadline;
            dbCategory.Client = epExpense.Client;
            dbCategory.ContactPerson= epExpense.ContactPerson;
            dbCategory.ContractDate = epExpense.ContractDate;
            dbCategory.ContractStatus = epExpense.ContractStatus;
            dbCategory.Probability = epExpense.Probability;
            dbCategory.Comments = epExpense.Comments;
            dbCategory.Value = epExpense.Value;
           
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

















        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Opportunity epExpense = await _context.Opportunities.Where(c => c.IsDeleted == false)
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
            Opportunity epExpense = await _context.Opportunities.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (epExpense == null) return NotFound();

            //_context.Categories.Remove(category);
            epExpense.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
