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
    public class TicketDiscountController : Controller
    {
        private readonly BioscoopContext _context;

        public TicketDiscountController(BioscoopContext context)
        {
            _context = context;
        }

        // GET: TicketDiscount
        public async Task<IActionResult> Index()
        {
            return View(await _context.TicketDiscounts.ToListAsync());
        }

        // GET: TicketDiscount/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketDiscount = await _context.TicketDiscounts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ticketDiscount == null)
            {
                return NotFound();
            }

            return View(ticketDiscount);
        }

        // GET: TicketDiscount/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TicketDiscount/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,description,discountAmount")] TicketDiscount ticketDiscount)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ticketDiscount);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ticketDiscount);
        }

        // GET: TicketDiscount/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketDiscount = await _context.TicketDiscounts.FindAsync(id);
            if (ticketDiscount == null)
            {
                return NotFound();
            }
            return View(ticketDiscount);
        }

        // POST: TicketDiscount/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,description,discountAmount")] TicketDiscount ticketDiscount)
        {
            if (id != ticketDiscount.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ticketDiscount);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TicketDiscountExists(ticketDiscount.ID))
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
            return View(ticketDiscount);
        }

        // GET: TicketDiscount/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ticketDiscount = await _context.TicketDiscounts
                .FirstOrDefaultAsync(m => m.ID == id);
            if (ticketDiscount == null)
            {
                return NotFound();
            }

            return View(ticketDiscount);
        }

        // POST: TicketDiscount/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ticketDiscount = await _context.TicketDiscounts.FindAsync(id);
            _context.TicketDiscounts.Remove(ticketDiscount);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TicketDiscountExists(int id)
        {
            return _context.TicketDiscounts.Any(e => e.ID == id);
        }
    }
}
