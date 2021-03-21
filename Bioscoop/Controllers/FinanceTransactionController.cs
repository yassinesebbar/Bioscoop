using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;
using System.Web;
using Microsoft.AspNetCore.Http;
using DinkToPdf;
using DinkToPdf.Contracts;




namespace Bioscoop.Controllers
{
    public class FinanceTransactionController : Controller
    {
        private readonly BioscoopContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConverter _converter;

        public FinanceTransactionController(IHttpContextAccessor IHTTPContext, BioscoopContext context, IConverter converter)
        {
            _context = context;
            _httpContextAccessor =IHTTPContext;
            _converter = converter;
        }

        // GET: FinanceTransaction
        public async Task<IActionResult> Index()
        {
            return View(await _context.FinanceTransactions.ToListAsync());
        }

        // GET: FinanceTransaction/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financeTransaction = await _context.FinanceTransactions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (financeTransaction == null)
            {
                return NotFound();
            }

            return View(financeTransaction);
        }

        // GET: FinanceTransaction/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FinanceTransaction/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,basePrice,ExtraTarif,descriptionExtraTarif,discount,totalPrice,DateTimeTransaction,IDdiscount")] FinanceTransaction financeTransaction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(financeTransaction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(financeTransaction); 
        }
       
    
        public async Task<IActionResult> DetailPaymentTablet(int? id)
        {
            var financeTransaction = await _context.FinanceTransactions
            .FirstOrDefaultAsync(m => m.ID == id);
    
            return View(financeTransaction);
        }

        public async Task<IActionResult> CreatePaymentTablet(int? id)
        {
            var financeTransaction = await _context.FinanceTransactions.FirstOrDefaultAsync(m => m.ID == id);

            var reservation = await _context.Reservations.FirstOrDefaultAsync(m => m.FinanceTransaction == financeTransaction);

            Payment payment = new Payment();
            payment.paymentMethod = PaymentMethod.MoneyTransfer;
            payment.reservation = reservation;
            payment.Banknr = new Random().Next(100000000, 999999999).ToString();
            payment.CouponCode = null;
            payment.Amount = financeTransaction.totalPrice;
            financeTransaction.paymentIsComplete = true;

            _context.Add(payment);
            _context.Update(reservation);
            _context.Update(financeTransaction);
            await _context.SaveChangesAsync();

            TempData["url"]  = "https://" + this.Request.Host.Value + "/FinanceTransaction/PrintTicketTablet/" + id;

            return RedirectToAction("Index", "Home");
        }


           public IActionResult PrintTicketTablet(int? id)
        {

            String url = "https://" + this.Request.Host.Value + "/FinanceTransaction/TemplateTicketTablet/" + id;
            PdfGenerator pdfGenerator = new PdfGenerator(_converter);

            return   File(pdfGenerator.CreatePDF(pdfGenerator.getHTML(url)), "application/pdf");

        }

        public IActionResult TemplateTicketTablet(int? id){
            return View();
        }

        // GET: FinanceTransaction/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financeTransaction = await _context.FinanceTransactions.FindAsync(id);
            if (financeTransaction == null)
            {
                return NotFound();
            }
            return View(financeTransaction);
        }

        // POST: FinanceTransaction/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,basePrice,ExtraTarif,descriptionExtraTarif,discount,totalPrice,DateTimeTransaction,IDdiscount")] FinanceTransaction financeTransaction)
        {
            if (id != financeTransaction.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(financeTransaction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FinanceTransactionExists(financeTransaction.ID))
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
            return View(financeTransaction);
        }

        // GET: FinanceTransaction/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var financeTransaction = await _context.FinanceTransactions
                .FirstOrDefaultAsync(m => m.ID == id);
            if (financeTransaction == null)
            {
                return NotFound();
            }

            return View(financeTransaction);
        }

        // POST: FinanceTransaction/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var financeTransaction = await _context.FinanceTransactions.FindAsync(id);
            _context.FinanceTransactions.Remove(financeTransaction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FinanceTransactionExists(int id)
        {
            return _context.FinanceTransactions.Any(e => e.ID == id);
        }
    }
}
