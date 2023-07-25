using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Interface;
using OnlineShop.Models;

namespace OnlineShop.Service
{
    public class ProductService : IProduct
    {
        private readonly OnlineShopContext _context;
        public ProductService(OnlineShopContext context)
        {
            _context = context;
        }

        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            _context.Products.Remove(GetProductById(id));
            _context.SaveChanges();
        }

        public ICollection<Product> GetAllProducts()
        {
            return _context.Products.Include(p => p.Category).ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include(p => p.Category).Where(p => p.Id == id).FirstOrDefault()!;
        }

        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
