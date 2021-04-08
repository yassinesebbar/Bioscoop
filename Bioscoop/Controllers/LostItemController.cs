using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;

namespace Bioscoop.Controllers
{
    public class LostItemController : Controller
    {
        private readonly BioscoopContext _context;

        public LostItemController(BioscoopContext context)
        {
            _context = context;
        }

        // GET: LostItem
        public async Task<IActionResult> Index()
        {
            return View(await _context.LostItems.ToListAsync());
        }

        // GET: LostItem/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lostItem = await _context.LostItems
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lostItem == null)
            {
                return NotFound();
            }

            return View(lostItem);
        }

        // GET: LostItem/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LostItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Description,DateLost,DateFound,EmployeeFound,EmployeeRelease,Image,LocationFound,ItemFound")] LostItem lostItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lostItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lostItem);
        }

        // GET: LostItem/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lostItem = await _context.LostItems.FindAsync(id);
            if (lostItem == null)
            {
                return NotFound();
            }
            return View(lostItem);
        }

        // POST: LostItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,DateLost,DateFound,EmployeeFound,EmployeeRelease,Image,LocationFound,ItemFound")] LostItem lostItem)
        {
            if (id != lostItem.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lostItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LostItemExists(lostItem.ID))
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
            return View(lostItem);
        }

        // GET: LostItem/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lostItem = await _context.LostItems
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lostItem == null)
            {
                return NotFound();
            }

            return View(lostItem);
        }

        // POST: LostItem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lostItem = await _context.LostItems.FindAsync(id);
            _context.LostItems.Remove(lostItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LostItemExists(int id)
        {
            return _context.LostItems.Any(e => e.ID == id);
        }
    }
}
