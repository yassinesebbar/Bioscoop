using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Bioscoop.Models;
using Bioscoop.Data;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Bioscoop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BioscoopContext _context;
        private readonly IActionContextAccessor _contextAccessor;
        private WLConfigSingleton _wlconfig;


        public HomeController(IActionContextAccessor contextAccessor, ILogger<HomeController> logger, BioscoopContext context)
        {
            _logger = logger;
            _context = context;

            _contextAccessor = contextAccessor;
            var ipString = _contextAccessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
            _wlconfig = _context.WLConfigSingleton.FirstOrDefault(m => m.ID == 1);
            var @ipObj = _context.WhiteListingIP.FirstOrDefault(m => m.IPaddress == ipString);
            _wlconfig.checkWhiteListing(@ipObj);


        }

        public async Task<IActionResult>  Index()
        {
            ViewData["wlapproved"] = _wlconfig.IPapproved;
            ViewBag.url = TempData["url"];

            return View(await _context.Movies.ToListAsync());
        }

           public async Task<IActionResult>  IndexApp()
        {
            ViewData["wlapproved"] = _wlconfig.IPapproved;
            ViewBag.url = TempData["url"];

            return View(await _context.Movies.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewData["wlapproved"] = _wlconfig.IPapproved;

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
