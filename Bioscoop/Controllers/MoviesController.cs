using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Bioscoop.Controllers
{
    public class MoviesController : Controller
    {
        private readonly BioscoopContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;  


        public MoviesController(BioscoopContext context, IWebHostEnvironment hostEnvironment)
        {

            _context = context;
            webHostEnvironment = hostEnvironment; 
        }

        // GET: Movies
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            ViewData["Dashboard"] = true;
            return View(await _context.Movies.ToListAsync());
        }

        // GET: Movies/Details/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Details(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // GET: Movies/Create
        [Authorize(Roles = "admin, user")]
        public IActionResult Create()
        {
            ViewData["Dashboard"] = true;

            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create(NonPersistantMovie NPmovie)
        {
            if (ModelState.IsValid)
            {
                ViewData["Dashboard"] = true;

                Movie movie =  new Movie{
                    ReleaseDate = NPmovie.ReleaseDate,
                    ImageCover = UploadedFile(NPmovie),
                    Title = NPmovie.Title,
                    Description = NPmovie.Description,
                    Genre = NPmovie.Genre,
                    RatingGuide = NPmovie.RatingGuide,
                    director = NPmovie.director,
                    Cast = NPmovie.Cast,
                    DurationMin = NPmovie.DurationMin,
                };

                _context.Add(movie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(NPmovie);
        }

        private string UploadedFile(NonPersistantMovie model)  
        {  
            string uniqueFileName = null;  
  
            if (model.movieCover != null)  
            {  
                string uploadsFolder = "wwwroot/images";  
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.movieCover.FileName;  
                string filePath = uploadsFolder + "/" + uniqueFileName;  
                using (var fileStream = new FileStream(filePath, FileMode.Create))  
                {  
                    model.movieCover.CopyTo(fileStream);  
                }  
            }  
            return uniqueFileName;  
        }



        // GET: Movies/Edit/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ReleaseDate,ImageCover,Title,Description,Genre,RatingGuide,director,Cast,DurationMin,Price")] Movie movie)
        {
            ViewData["Dashboard"] = true;

            if (id != movie.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MovieExists(movie.ID))
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
            return View(movie);
        }

        // GET: Movies/Delete/5
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Delete(int? id)
        {
            ViewData["Dashboard"] = true;

            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            ViewData["Dashboard"] = true;

            var movie = await _context.Movies.FindAsync(id);
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.ID == id);
        }
    }
}
