using OnlineShop.Data;
using OnlineShop.Interface;
using OnlineShop.Models;

namespace OnlineShop.Service
{
    public class CategoryService : ICategory
    {
        private readonly OnlineShopContext _context;
        public CategoryService(OnlineShopContext context)
        {
            _context = context;
        }

        public void CreateCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            _context.Categories.Remove(GetCategoryById(id));
            _context.SaveChanges();
        }

        public ICollection<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Where(c => c.Id == id).FirstOrDefault()!;
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }
    }
}
