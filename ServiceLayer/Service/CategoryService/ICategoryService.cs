using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.DTO;

namespace ServiceLayer.Service.CategoryService
{
    public interface ICategoryService
    {
        List<CategoryDto> getCatgories();
        CategoryDto getCategory(int id);
        void addCategory(CategoryDto dto);
        void removeCategory(int id);
        void updateCategory(int id, CategoryDto dto);
    }
}
