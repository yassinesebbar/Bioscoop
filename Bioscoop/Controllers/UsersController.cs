using Bioscoop.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bioscoop.Controllers
{
    public class UsersController : Controller
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly BioscoopContext _context;

        public UsersController(UserManager<IdentityUser> userManager, BioscoopContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        { 
            return View( _userManager.Users.ToList());
        }

        public async Task<IActionResult> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                return RedirectToAction("Index");
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return RedirectToAction("Index");
        }
    }
}
