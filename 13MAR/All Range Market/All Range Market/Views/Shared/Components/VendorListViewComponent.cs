using Microsoft.AspNetCore.Mvc;
using System.Linq;
using All_Range_Market.Models;
using System.Security.Cryptography.X509Certificates;

namespace All_Range_Market.Components
{
    public class VendorListViewComponent : ViewComponent
    {
        private IVendorRepository repository;
        public VendorListViewComponent(IVendorRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedVendor = RouteData?.Values["Brand"];
            return View(repository.Vendors.Select(x => x.Brand).Distinct().OrderBy(x => x));
        }
    }
}