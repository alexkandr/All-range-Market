using System.Collections.Generic;
using All_Range_Market.Models;

namespace All_Range_Market.Models.ViewModels
{
    public class ShopListViewModel
    {
        public IEnumerable<Comment> Comments { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
