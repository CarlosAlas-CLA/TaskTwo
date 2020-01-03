using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaskTwo;
using TaskTwo.Models;

namespace TaskTwo.Controllers
{
    public class MasterPagesController : Controller
    {
        private readonly Context _context;

        public MasterPagesController(Context context)
        {
            _context = context;
        }

        // GET: MasterPages
        public async Task<IActionResult> Index()
        {
            return View(await _context.masterPages.ToListAsync());
        }

        // GET: MasterPages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterPage = await _context.masterPages
                .FirstOrDefaultAsync(m => m.MasterPageID == id);
            if (masterPage == null)
            {
                return NotFound();
            }

            return View(masterPage);
        }

        // GET: MasterPages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MasterPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MasterPageID,LastDayQtySold,LastDayProfit,TotalProducts")] MasterPage masterPage)
        {
            if (ModelState.IsValid)
            {
                _context.Add(masterPage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(masterPage);
        }

        // GET: MasterPages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterPage = await _context.masterPages.FindAsync(id);
            if (masterPage == null)
            {
                return NotFound();
            }
            return View(masterPage);
        }

        // POST: MasterPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MasterPageID,LastDayQtySold,LastDayProfit,TotalProducts")] MasterPage masterPage)
        {
            if (id != masterPage.MasterPageID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(masterPage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MasterPageExists(masterPage.MasterPageID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(masterPage);
        }

        // GET: MasterPages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var masterPage = await _context.masterPages
                .FirstOrDefaultAsync(m => m.MasterPageID == id);
            if (masterPage == null)
            {
                return NotFound();
            }

            return View(masterPage);
        }

        // POST: MasterPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var masterPage = await _context.masterPages.FindAsync(id);
            _context.masterPages.Remove(masterPage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MasterPageExists(int id)
        {
            return _context.masterPages.Any(e => e.MasterPageID == id);
        }
    }
}
