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
using Bioscoop.ViewDataWrapper;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Bioscoop.Controllers
{
    public class LostItemController : Controller
    {
        private readonly BioscoopContext _context;
        private readonly IHttpContextAccessor _HttpContext;

        public LostItemController(BioscoopContext context, IHttpContextAccessor httpContext)
        {
            _context = context;
            _HttpContext = httpContext;
        }

        // GET: LostItem
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            ViewData["Dashboard"] = true;
            return View(await _context.LostItems.ToListAsync());
        }

        // GET: LostItem/Details/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Dashboard"] = true;

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
        [Authorize(Roles = "admin, user")]
        public IActionResult Create()
        {
            ViewData["Dashboard"] = true;

            return View();
        }

        // POST: LostItem/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create(NonPersistantLostItems nonPersistantLostItems)
        {
            ViewData["Dashboard"] = true;

            if (ModelState.IsValid)
            {
                LostItem lostItem = new LostItem
                {
                    Description = nonPersistantLostItems.Description,
                    DateLost = nonPersistantLostItems.DateLost,
                    EmployeeFound = nonPersistantLostItems.EmployeeFound,
                    Image = UploadedFile(nonPersistantLostItems),
                    LocationFound = nonPersistantLostItems.LocationFound,
                    ItemFound = nonPersistantLostItems.ItemFound,
                };

                _context.Add(lostItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(nonPersistantLostItems);
        }

        // GET: LostItem/Edit/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> FoundItem(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var lostItem = await _context.LostItems.FindAsync(id);
            if (lostItem == null)
            {
                return NotFound();
            }

            lostItem.ItemFound = true;
            lostItem.DateFound = DateTime.Now;
            lostItem.EmployeeRelease = _HttpContext.HttpContext.User.Identity.Name;

            _context.Update(lostItem);
            _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // POST: LostItem/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Description,DateLost,DateFound,EmployeeFound,EmployeeRelease,Image,LocationFound,ItemFound")] LostItem lostItem)
        {
            ViewData["Dashboard"] = true;

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

        private string UploadedFile(NonPersistantLostItems model)
        {
            string uniqueFileName = null;

            if (model.ImageLostItem != null)
            {
                string uploadsFolder = "wwwroot/imagesItems";
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageLostItem.FileName;
                string filePath = uploadsFolder + "/" + uniqueFileName;
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageLostItem.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        // GET: LostItem/Delete/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["Dashboard"] = true;

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
        [Authorize(Roles = "admin, user")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            ViewData["Dashboard"] = true;

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
