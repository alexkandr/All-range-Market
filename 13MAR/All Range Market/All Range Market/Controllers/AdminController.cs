using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace All_Range_Market.Controllers
{
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<IdentityUser> userManager;

        public AdminController(RoleManager<IdentityRole> rlMgr, UserManager<IdentityUser> userMgr)
        {
            roleManager = rlMgr;
            userManager = userMgr;
        }
        public IActionResult ControlPanel() => View();

    }
}
