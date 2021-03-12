using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_Range_Market.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string User { get; set; }
        public Vendor Vendor { get; set; }
        public DateTime Time { get; set; }
        public string Content { get; set; }
    }
}
