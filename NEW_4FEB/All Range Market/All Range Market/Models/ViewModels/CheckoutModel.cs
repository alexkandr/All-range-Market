using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_Range_Market.Models;
using All_Range_Market.Pages;

namespace All_Range_Market.Models.ViewModels
{
    public class CheckoutModel
    {
        public Order order { get; set; }
        public List<SpotAdress> AvailableAdresses { get; set; }
        public CheckoutModel(Order p_order)
        {
            order = p_order;
            AvailableAdresses = new List<SpotAdress> 
            { new SpotAdress { Country = "Россия", City = "Москва", Adress = "Кедрова 21, кв 3" } };
        }
    }
    public class SpotAdress
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string Zip { get; set; }
        public string Result => $"{Country}, {City} {Adress}. {Zip}";
    }

}
