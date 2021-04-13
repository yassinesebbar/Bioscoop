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
using Microsoft.AspNetCore.Mvc.Infrastructure;


namespace Bioscoop.Controllers
{
    public class EventsController : Controller
    {
        private readonly BioscoopContext _context;
        private readonly IActionContextAccessor _contextAccessor;
        private WLConfigSingleton _wlconfig;



        public EventsController(IActionContextAccessor contextAccessor, BioscoopContext context)
        {
            _context = context;
      }

        // GET: Events
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            ViewData["Dashboard"] = true;

            return View(await _context.Events.Include(e => e.Movie)
                                            .Include(e => e.AvailableSeats)
                                            .Include(e => e.ReservedSeats)
                                            .Include(e => e.Hall)
                                            .ToListAsync());
        }

        // GET: Events/Details/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.ID == id);

            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }


        public async Task<IActionResult> EventsMovieFilterApp(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            
            ViewData["Movie"] = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            ViewData["Events"] =   _context.Events.Where(e => e.IDmovie == id).Where(r => r.Start > DateTime.Now).ToList();
            ViewData["TicketDiscounts"] = await _context.TicketDiscounts.ToListAsync();



            return View();
        }

         public async Task<IActionResult> EventsMovieFilter(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            ViewData["Movie"] = await _context.Movies.FirstOrDefaultAsync(m => m.ID == id);
            ViewData["Events"] =   _context.Events.Where(e => e.IDmovie == id).ToList();
            ViewData["TicketDiscounts"] = await _context.TicketDiscounts.ToListAsync();



            return View();
        }

        // GET: Events/Create
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create()
        {
            ViewData["Dashboard"] = true;

            ViewData["Halls"] = await _context.Halls.ToListAsync();
            ViewData["Movies"] = await _context.Movies.ToListAsync();

            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create([Bind("ID,Start,End, IDhall, IDmovie")] Event @event)
        {
            ViewData["Dashboard"] = true;

            @event.Movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == @event.IDmovie);

            @event.Hall = await _context.Halls.Include(h => h.Seats)
                .FirstOrDefaultAsync(m => m.ID == @event.IDhall);

                @event.setHallInformation(_context);
                @event.setBasePrijs();

                ModelState.Clear();

            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Halls"] = await _context.Halls.ToListAsync();
            ViewData["Movies"] = await _context.Movies.ToListAsync();

            return View(@event);
        }

        // GET: Events/Edit/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Start,End")] Event @event)
        {
            ViewData["Dashboard"] = true;

            if (id != @event.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.ID))
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
            return View(@event);
        }

        // GET: Events/Delete/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.ID == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["Dashboard"] = true;

            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.ID == id);
        }
    }
}
