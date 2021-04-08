using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioscoop.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> _roleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult Index()
        {
            ViewData["Dashboard"] = true;

            var roles = _roleManager.Roles.ToList();

            return View(roles);
        }

        [Authorize(Roles = "admin, user")]
        public IActionResult Create()
        {
            ViewData["Dashboard"] = true;

            return View(new IdentityRole());
        }

        [HttpPost]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            ViewData["Dashboard"] = true;

            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}
