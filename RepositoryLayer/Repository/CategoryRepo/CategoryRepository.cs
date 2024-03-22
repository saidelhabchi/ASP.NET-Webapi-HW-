using RepositoryLayer.Context;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.CategoryRepo
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void addCategory(Category category)
        {
            if(category !=  null) _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public Category? getCategory(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public List<Category> getCatgories()
        {
            return _context.Categories.ToList();
        }

        public void removeCategory(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if(category != null) 
            {
                _context.Categories.Remove(category);
            }
           _context.SaveChanges();
        }

        public void updateCategory(int id, Category category)
        {
            var _category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if(_category != null)
            {
                _category.Name = category.Name;
                _category.Products = category.Products;
            }
            _context.SaveChanges();
        }
    }
}
