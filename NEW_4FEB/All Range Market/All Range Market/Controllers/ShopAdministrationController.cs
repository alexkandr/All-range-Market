using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using All_Range_Market.Models;

namespace All_Range_Market.Controllers
{
    [Authorize(Roles ="Brand")]
    public class ShopAdministrationController : Controller
    {
        private IProductRepository repository;
        public ShopAdministrationController(IProductRepository rep)
        {
            repository = rep;
        }

        public IActionResult Main()
        {
            return View();
        }
    }
}
