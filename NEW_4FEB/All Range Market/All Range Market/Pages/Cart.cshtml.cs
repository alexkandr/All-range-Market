using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using All_Range_Market.Infrastructure;
using All_Range_Market.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace All_Range_Market.Pages
{
 public class CartModel : PageModel
    {
        private IProductRepository repository;
        public CartModel(IProductRepository repo)
        {
            repository = repo;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        public IActionResult OnPost(long productId, string returnUrl, int sizeId=1)
        {
            Product product = repository.Products.Include(p => p.AvaibleSizes)
            .FirstOrDefault(p => p.ProductId == productId);
            ProductSize size = product.AvaibleSizes.FirstOrDefault(s => s.Id == sizeId);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(product, size, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}