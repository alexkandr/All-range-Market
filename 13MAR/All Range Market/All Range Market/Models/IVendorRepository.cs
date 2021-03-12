using All_Range_Market.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace All_Range_Market.Models
{
    public interface IVendorRepository
    {
        public IQueryable<Vendor> Vendors { get; }
        public void SaveVendor(Vendor vendor);
        public void CreateVendor(Vendor vendor);
        public void DeleteVendor(Vendor vendor);
    }
}
