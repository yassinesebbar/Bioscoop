using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;
using Bioscoop.ViewDataWrapper;

namespace Bioscoop.Controllers
{
    public class WhiteListingIPController : Controller
    {
        private readonly BioscoopContext _context;

        public WhiteListingIPController(BioscoopContext context)
        {
            _context = context;
        }

        // GET: WhiteListingIP
        public async Task<IActionResult> Index()
        {
            ViewData["Dashboard"] = true;


            WhiteListing whitelisting = new WhiteListing();

            whitelisting.IPlist = await _context.WhiteListingIP.ToListAsync();
            whitelisting.WLconfig = await _context.WLConfigSingleton.FirstOrDefaultAsync(m => m.ID == 1);
            whitelisting.wlconfigbool = whitelisting.WLconfig.WhiteListing;
            whitelisting.wlconfigid = whitelisting.WLconfig.ID;

            return View(whitelisting);
        }

        public async Task<IActionResult> EditConfig(int wlconfigid, bool wlconfigbool)
        {

            WLConfigSingleton WLconfig = await _context.WLConfigSingleton.FirstOrDefaultAsync(m => m.ID == wlconfigid);
            
            if (WLconfig != null && wlconfigbool != null)
            {
                WLconfig.WhiteListing = wlconfigbool;
                _context.Update(WLconfig);
                await _context.SaveChangesAsync();
            }


            return RedirectToAction("Index");
        }

        // GET: WhiteListingIP/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Dashboard"] = true;


            if (id == null)
            {
                return NotFound();
            }

            var whiteListingIP = await _context.WhiteListingIP
                .FirstOrDefaultAsync(m => m.ID == id);
            if (whiteListingIP == null)
            {
                return NotFound();
            }

            return View(whiteListingIP);
        }

        // GET: WhiteListingIP/Create
        public IActionResult Create()
        {
            ViewData["Dashboard"] = true;


            return View();
        }

        // POST: WhiteListingIP/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,IPaddress")] WhiteListingIP whiteListingIP)
        {

            ViewData["Dashboard"] = true;


            if (ModelState.IsValid)
            {
                _context.Add(whiteListingIP);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(whiteListingIP);
        }

        // GET: WhiteListingIP/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            ViewData["Dashboard"] = true;


            if (id == null)
            {
                return NotFound();
            }

            var whiteListingIP = await _context.WhiteListingIP.FindAsync(id);
            if (whiteListingIP == null)
            {
                return NotFound();
            }
            return View(whiteListingIP);
        }

        // POST: WhiteListingIP/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,IPaddress")] WhiteListingIP whiteListingIP)
        {
            ViewData["Dashboard"] = true;


            if (id != whiteListingIP.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(whiteListingIP);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WhiteListingIPExists(whiteListingIP.ID))
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
            return View(whiteListingIP);
        }

        // GET: WhiteListingIP/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {

            ViewData["Dashboard"] = true;


            if (id == null)
            {
                return NotFound();
            }

            var whiteListingIP = await _context.WhiteListingIP
                .FirstOrDefaultAsync(m => m.ID == id);
            if (whiteListingIP == null)
            {
                return NotFound();
            }

            return View(whiteListingIP);
        }

        // POST: WhiteListingIP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["Dashboard"] = true;


            var whiteListingIP = await _context.WhiteListingIP.FindAsync(id);
            _context.WhiteListingIP.Remove(whiteListingIP);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WhiteListingIPExists(int id)
        {
            return _context.WhiteListingIP.Any(e => e.ID == id);
        }
    }
}
