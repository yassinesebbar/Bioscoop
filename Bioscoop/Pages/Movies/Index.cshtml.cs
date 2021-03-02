using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Data;
using Bioscoop.Models;

namespace Bioscoop.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Bioscoop.Data.BioscoopContext _context;

        public IndexModel(Bioscoop.Data.BioscoopContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
