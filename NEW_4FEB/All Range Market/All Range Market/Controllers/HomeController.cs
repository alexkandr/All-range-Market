using Microsoft.AspNetCore.Mvc;
using All_Range_Market.Models;
using System.Linq;
using All_Range_Market.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using All_Range_Market.Components;
using System.Collections.Generic;

namespace All_Range_Market.Controllers {
    public class HomeController : Controller {
        private IProductRepository  repository;
        private IVendorRepository vend_rep;
        private ICommentsRepository com_rep;
        public int PageSize = 4;

        public HomeController(IProductRepository p_rep, IVendorRepository v_rep, ICommentsRepository c_rep) 
        {
            repository = p_rep;
            vend_rep = v_rep;
            com_rep = c_rep;
        }

        public IActionResult Catalog(string orderby, string category, int productPage = 1)
        {
            var ProductList = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .Include(p => p.Vendor)
                    .Include(p => p.Images);
            IQueryable<Product> ResultList;
            switch(orderby)
            {
                case "Price":  ResultList = ProductList.OrderBy(p => p.Price)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize);
                    break;

                case "Vendor":
                    ResultList = ProductList.OrderBy(p => p.Vendor.Brand)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize);
                    break;

                case "Name":
                     ResultList = ProductList.OrderBy(p => p.Name)
                     .Skip((productPage - 1) * PageSize)
                     .Take(PageSize);
                    break;
                default:
                    ResultList = ProductList.OrderBy(p => p.ProductId)
                     .Skip((productPage - 1) * PageSize)
                     .Take(PageSize);
                    break;
            }
                    
            return
            View(new ProductsListViewModel
            {
                Products = ResultList,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                        repository.Products.Count() :
                        repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory = category
            });
        }
        public IActionResult Index() => 
            View(repository.Products.Include(p=>p.Vendor).Include(prop=>prop.Images)
                .OrderBy(p => p.Price).Take(PageSize));

        public IActionResult About() => View();
        public IActionResult Shop(string brand, int productPage = 1)
        {
            return View(new ShopListViewModel
            {
                Products = repository.Products.Include(p => p.Vendor)
                .Include(p => p.Images).Where(v => v.Vendor.Brand == brand)
                .OrderBy(p => p.ProductId).ToList(),
                Comments = (com_rep.Comments != null) ?
                com_rep.Comments.Include(c => c.Vendor).Where(c => c.Vendor.Brand == brand).ToList() :
                new List<Comment>()
            }) ;
        }
        public IActionResult SingleProduct(string brand, int productId)
        {
            var a = repository.Products.Include(p => p.Vendor)
                .Include(p=>p.AvaibleSizes).Include(p => p.Images).FirstOrDefault(p => p.ProductId == productId);
            return View(a);
        }

    }
}
