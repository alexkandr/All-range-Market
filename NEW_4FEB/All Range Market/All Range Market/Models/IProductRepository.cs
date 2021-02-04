using System.Linq;

namespace All_Range_Market.Models
{
    public interface IProductRepository   
    {

        IQueryable<Product> Products { get; }

        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}
