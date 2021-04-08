using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;
using Microsoft.AspNetCore.Authorization;

namespace Bioscoop.Controllers
{
    public class HallsController : Controller
    {
        private readonly BioscoopContext _context;

        public HallsController(BioscoopContext context)
        {
            _context = context;
        }

        // GET: Halls
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            ViewData["Dashboard"] = true;
            return View(await _context.Halls.ToListAsync());
        }

        // GET: Halls/Details/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Dashboard"] = true;
            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls.Include(m => m.Seats)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hall == null)
            {
                return NotFound();
            }

            return View(hall);
        }

        // GET: Halls/Create
        [Authorize(Roles = "admin, user")]
        public IActionResult Create()
        {
            ViewData["Dashboard"] = true;
            return View();
        }

        // POST: Halls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create([Bind("ID,Description,Rows,SeatsPerRow, Name")] Hall hall)
        {
            ViewData["Dashboard"] = true;

            if (ModelState.IsValid)
            {
                _context.Add(hall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hall);
        }

        // GET: Halls/Edit/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Dashboard"] = true;
            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls.FindAsync(id);
            if (hall == null)
            {
                return NotFound();
            }
            return View(hall);
        }

        // POST: Halls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,Rows,SeatsPerRow")] Hall hall)
        {
            ViewData["Dashboard"] = true;
            if (id != hall.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HallExists(hall.ID))
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
            return View(hall);
        }

        // GET: Halls/Delete/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["Dashboard"] = true;
            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls
                .FirstOrDefaultAsync(m => m.ID == id);
            if (hall == null)
            {
                return NotFound();
            }

            return View(hall);
        }

        // POST: Halls/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin, user")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hall = await _context.Halls.FindAsync(id);
            _context.Halls.Remove(hall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HallExists(int id)
        {
            return _context.Halls.Any(e => e.ID == id);
        }
    }
}
