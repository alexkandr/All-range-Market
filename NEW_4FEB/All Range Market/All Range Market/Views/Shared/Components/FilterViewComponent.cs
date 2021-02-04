using Microsoft.AspNetCore.Mvc;
using System.Linq;
using All_Range_Market.Models;

namespace All_Range_Market.Views.Shared.Components
{
    public class FilterViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke() => View();
    }
}
