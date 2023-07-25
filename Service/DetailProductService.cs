using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Interface;
using OnlineShop.Models;

namespace OnlineShop.Service
{
    public class DetailProductService : IDetailProduct
    {
        private readonly OnlineShopContext _context;
        public DetailProductService(OnlineShopContext context)
        {
            _context = context;
        }
        public void CreateDetailProduct(DetailProduct detailProduct)
        {
            _context.DetailProducts.Add(detailProduct);
            _context.SaveChanges();
        }

        public void DeleteDetailProduct(int id)
        {
            _context.DetailProducts.Remove(GetDetailProductByIdProduct(id));
        }

        public ICollection<DetailProduct> GetAllDetails()
        {
            return _context.DetailProducts.Include(d => d.Product).ToList();
        }

        public DetailProduct GetDetailProductByIdProduct(int id)
        {
            return _context.DetailProducts.Include(d => d.Product).Where(d => d.Product.Id == id).FirstOrDefault()!;
        }

        public void UpdateDetailProduct(DetailProduct detailProduct)
        {
            _context.DetailProducts.Update(detailProduct);
            _context.SaveChanges();
        }
    }
}
