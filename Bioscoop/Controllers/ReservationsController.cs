using System.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace Bioscoop.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly BioscoopContext _context;
        private readonly IConverter _converter;


        public ReservationsController(BioscoopContext context, IConverter converter)
        {
            _context = context;
            _converter = converter;

        }

        // GET: Reservations
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            ViewData["Dashboard"] = true;
            return View(await _context.Reservations.ToListAsync());
        }

        // GET: Reservations/Details/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Event)
                .Include(r => r.FinanceTransaction)
                .Include(r => r.StoelNr)
                .Include(r => r.FinanceTransaction.Discount)
                .Include(r => r.Event.Hall)
                .FirstOrDefaultAsync(m => m.ID == id);
                
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        [Authorize(Roles = "admin, user")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Reservations/Creates
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateApp([Bind("ID,StoelNr,geanuleerd,ReservationDate,IDtransaction,IDevent")] Reservation reservation, int IDdiscount)
        {
                var Event = await _context.Events.Include(e => e.Movie).Include(e => e.ReservedSeats).Include(e => e.AvailableSeats).Where(e => e.ID == reservation.IDevent).SingleAsync();

                reservation.setReservation(
                    Event,
                    await _context.TicketDiscounts.FirstOrDefaultAsync(d => d.ID == IDdiscount));

                _context.Add(reservation);  
                _context.Add(reservation.FinanceTransaction);
                _context.Update(reservation.getStoelNr());

                await _context.SaveChangesAsync();

                return RedirectToAction("DetailPaymentApp", "FinanceTransaction", new { id = reservation.FinanceTransaction.ID });
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,StoelNr,geanuleerd,ReservationDate,IDtransaction,IDevent,Name,LastName,Email")] Reservation reservation, int IDdiscount)
        {
                var Event = await _context.Events.Include(e => e.Movie).Include(e => e.ReservedSeats).Include(e => e.AvailableSeats).Where(e => e.ID == reservation.IDevent).SingleAsync();

                reservation.setReservation(
                    Event,
                    await _context.TicketDiscounts.FirstOrDefaultAsync(d => d.ID == IDdiscount));

                _context.Add(reservation);  
                _context.Add(reservation.FinanceTransaction);
                _context.Update(reservation.getStoelNr());

                await _context.SaveChangesAsync();

                return RedirectToAction("DetailPayment", "FinanceTransaction", new { id = reservation.FinanceTransaction.ID });
            
        }

        // GET: Reservations/Edit/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Dashboard"] = true;
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,StoelNr,geanuleerd,ReservationDate,IDtransaction,IDevent")] Reservation reservation)
        {
            ViewData["Dashboard"] = true;
            if (id != reservation.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.ID))
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
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["Dashboard"] = true;
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations

                .FirstOrDefaultAsync(m => m.ID == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        public  IActionResult printReservation(int? id)
        {
            String url = "https://" + this.Request.Host.Value + "/Reservations/TemplateReservationPDF/" + id;
            PdfGenerator pdfGenerator = new PdfGenerator(_converter);

            return   File(pdfGenerator.CreatePDF(pdfGenerator.getHTML(url), new PechkinPaperSize("120mm", "41mm")), "application/pdf");
        }

         public IActionResult TemplateReservationPDF(int? id){
            
            Reservation reservation = _context.Reservations.Include(m => m.StoelNr).FirstOrDefault(m => m.ID == id);
            ViewData["event"] = _context.Events.Include(m => m.Movie).FirstOrDefault(m => m.ID == reservation.IDevent);
            ViewBag.printUrl = true; 

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "admin, user")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["Dashboard"] = true;
            var reservation = await _context.Reservations.FindAsync(id);
            _context.Reservations.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.ID == id);
        }
    }
}
