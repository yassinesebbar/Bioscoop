using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioscoop.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            ViewData["Dashboard"] = true;
            return View();
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult MovieOverview()
        {
            return RedirectToAction("Index", "Movies");
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult EventOverview()
        {
            return RedirectToAction("Index", "Events");
        }

        [Authorize(Roles = "admin, user")]
        public RedirectToActionResult ReservationOverview()
        {
            return RedirectToAction("Index", "Reservations");
        }

        [Authorize(Roles = "admin")]
        public RedirectToActionResult RoleOverview()
        {
            return RedirectToAction("Index", "Role");
        }

        [Authorize(Roles = "admin")]
        public RedirectToActionResult HallOverview()
        {
            return RedirectToAction("Index", "Halls");
        }
    }
}
