using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Range_Market.Models.ViewModels
{
    public class IndexListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public List<string> Banners { get; set; }
        public List<string> Description { get; set; }
        public List<string> Urls { get; set; }
    }
}
