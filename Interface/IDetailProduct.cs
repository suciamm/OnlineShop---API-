using OnlineShop.Models;

namespace OnlineShop.Interface
{
    public interface IDetailProduct
    {
        ICollection<DetailProduct> GetAllDetails();
        DetailProduct GetDetailProductByIdProduct(int id);
        void CreateDetailProduct(DetailProduct detailProduct);
        void UpdateDetailProduct(DetailProduct detailProduct);
        void DeleteDetailProduct(int id);
    }
}
