using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository.CategoryRepo
{
    public interface ICategoryRepository
    {
        List<Category> getCatgories();
        Category? getCategory(int id);
        void addCategory(Category category);
        void removeCategory(int id);
        void updateCategory(int id, Category category);
    }
}
