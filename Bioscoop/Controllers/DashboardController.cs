using Bioscoop.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bioscoop.Models;
using Microsoft.EntityFrameworkCore;
using Bioscoop.ViewDataWrapper;

namespace Bioscoop.Controllers
{
    public class DashboardController : Controller
    {

        private readonly IActionContextAccessor _contextAccessor;
        private readonly BioscoopContext _context;
        private WLConfigSingleton _wlconfig;


        public DashboardController(IActionContextAccessor contextAccessor, BioscoopContext context)
        {
            _context = context;

            _contextAccessor = contextAccessor;
            var ipString = _contextAccessor.ActionContext.HttpContext.Connection.RemoteIpAddress.ToString();
            _wlconfig =  _context.WLConfigSingleton.FirstOrDefault(m => m.ID == 1);
            var @ipObj = _context.WhiteListingIP.FirstOrDefault(m => m.IPaddress == ipString);
            _wlconfig.checkWhiteListing(@ipObj);

        }

        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Index()
        {
            if (_wlconfig.IPapproved)
            {
                HomeDashboard homedashboard = new HomeDashboard();
                homedashboard.reservationList = await _context.Reservations.Include(r => r.Event).Where(r => r.Event.Start.Date == DateTime.Now.Date).ToListAsync();
                homedashboard.eventList = await _context.Events.Where(r => r.Start.Date == DateTime.Now.Date).ToListAsync();

                ViewData["Dashboard"] = true;
                return View(homedashboard);
            }

           return RedirectToAction("Index", "Home"); 
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult MovieOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "Movies");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult EventOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "Events");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult ReservationOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "Reservations");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin")]
        public RedirectToActionResult RoleOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "Role");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin")]
        public RedirectToActionResult HallOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "Halls");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult LostItemOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "LostItem");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin")]
        public RedirectToActionResult WhiteListingOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "WhiteListingIP");
            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize(Roles = "admin")]
        public RedirectToActionResult UserOverview()
        {
            if (_wlconfig.IPapproved)
            {
                return RedirectToAction("Index", "Users");
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
