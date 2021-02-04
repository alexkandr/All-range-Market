using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace All_Range_Market.Models
{
    public class EFVendorRepository : IVendorRepository
    {
        private StoreDbContext context;
        public EFVendorRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Vendor> Vendors => context.Vendors;

        public void CreateVendor(Vendor v)
        {
            context.Add(v);
            context.SaveChanges();
        }

        public void DeleteVendor(Vendor v)
        {
            context.Remove(v);
            context.SaveChanges();
        }

        public void SaveVendor(Vendor v)
        {
            context.SaveChanges();
        }
    }
}
