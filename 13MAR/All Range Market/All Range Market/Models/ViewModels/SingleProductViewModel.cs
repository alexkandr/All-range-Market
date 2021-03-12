using System;
using System.Collections.Generic;
using All_Range_Market.Models;
namespace All_Range_Market.Models.ViewModels
{
    public class SingleProductViewModel
    {
        public Product Product { get; set; }
        public List<Product> Previous { get; set; }
    }
}
