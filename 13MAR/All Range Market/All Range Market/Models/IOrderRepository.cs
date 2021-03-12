using System.Linq;

namespace All_Range_Market.Models
{

    public interface IOrderRepository
    {

        IQueryable<Order> Orders { get; }
        void SaveOrder(Order order);
    }
}
