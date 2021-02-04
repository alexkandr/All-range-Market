using System;
using System.Collections.Generic;
using System.Linq;

namespace All_Range_Market.Models
{
    public class Vendor
    {
        public int VendorId { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public double TrustRate { get; set; }
        public List<Product> Products { get; set; }
    }
}
