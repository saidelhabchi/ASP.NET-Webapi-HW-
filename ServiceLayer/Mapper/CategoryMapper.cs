using RepositoryLayer.Model;
using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapper
{
    public static class CategoryMapper
    {
        public static CategoryDto ToCategoryDto(Category category) 
        {
            return new CategoryDto()
            {
                Id = category.Id,
                Name = category.Name,
                //ProductDtos = ProductMapper.ToProductDtos(category.Products),
            }; 
        }
        public static Category? ToCategory(CategoryDto dto) 
        {
            if (dto == null) return null;

            return new Category
            {
                Id = dto.Id,
                Name = dto.Name,
                //Products = ProductMapper.ToProducts(dto.ProductDtos),
            };
        }
        /*
        public static Category? ToCategory(CreateCategoryDto dto) 
        {
            if (dto == null) return null;

            return new Category { Name = dto.Name };
        }
        */
        /*
        public static Category? ToCategory(UpdateCategoryDto dto) 
        {

            if (dto == null) return null;

            return new Category { 
                Name= dto.Name, 
                Products= ProductMapper.ToProducts(dto.productDtos)
            };
        }
        */
        public static List<Category> ToCategories(List<CategoryDto> categories) 
        {
            if (categories == null)
            {
                return new List<Category>();
            }
            return categories.Select(c => ToCategory(c)).ToList();
        }
        public static List<CategoryDto> ToCategoriesDto (List<Category> dtos) 
        {
            if (dtos == null)
            {
                return new List<CategoryDto>();
            }
            return dtos.Select(c => ToCategoryDto(c)).ToList();
        }
    }
}
