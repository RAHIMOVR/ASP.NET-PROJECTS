using EpsilonLocal.DAL;
using EpsilonLocal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpsilonLocal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EpExpenseController : Controller
    {
        private readonly AppDbContext _context;
        public EpExpenseController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.EpExpenses.Where(c => c.IsDeleted == false).ToListAsync());
        }
        public ActionResult Create()
        {
             return View();
        } 
        public ActionResult Info()
        {
           return View();
        }

        public ActionResult InfoSection()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EpExpense epExpense)
        {
            if (!ModelState.IsValid) return View();
            epExpense.IsDeleted = false;
            await _context.EpExpenses.AddAsync(epExpense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            EpExpense category = await _context.EpExpenses.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(EpExpense epExpense)
        {
            if (!ModelState.IsValid) return View(epExpense);
            EpExpense dbCategory = await _context.EpExpenses.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == epExpense.Id);
            if (dbCategory == null) return NotFound();
           dbCategory.Id= epExpense.Id;
            dbCategory.Category = epExpense.Category;
            dbCategory.IsDeleted = epExpense.IsDeleted;
            dbCategory.Date=epExpense.Date;
            dbCategory.Description = epExpense.Description;
            dbCategory.ExpenseAmount = epExpense.ExpenseAmount;
            dbCategory.İncomingAmount = epExpense.İncomingAmount;
            dbCategory.Person=epExpense.Person;
            dbCategory.Month=epExpense.Month;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            EpExpense epExpense = await _context.EpExpenses.Where(c => c.IsDeleted == false)
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
            EpExpense epExpense = await _context.EpExpenses.Where(c => c.IsDeleted == false)
                .FirstOrDefaultAsync(c => c.Id == id);
            if (epExpense == null) return NotFound();

            //_context.Categories.Remove(category);
            epExpense.IsDeleted = true;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
