using OnlineShop.Models;

namespace OnlineShop.Interface
{
    public interface IProduct
    {
        ICollection<Product> GetAllProducts();
        Product GetProductById(int id);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}