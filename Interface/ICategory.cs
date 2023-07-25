using OnlineShop.Models;

namespace OnlineShop.Interface
{
    public interface ICategory
    {
        ICollection<Category> GetAllCategories();
        Category GetCategoryById(int id);
        void CreateCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}