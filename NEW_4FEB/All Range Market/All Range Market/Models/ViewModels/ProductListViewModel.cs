using System.Collections.Generic;
using All_Range_Market.Models;

namespace All_Range_Market.Models.ViewModels
{

    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
