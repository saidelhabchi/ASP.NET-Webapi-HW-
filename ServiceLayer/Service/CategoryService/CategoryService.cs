using RepositoryLayer.Model;
using RepositoryLayer.Repository.CategoryRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Mapper;
using ServiceLayer.DTO;
using AutoMapper;

namespace ServiceLayer.Service.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        //private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void addCategory(CategoryDto dto)
        {
            //_categoryRepository.addCategory(_mapper.Map<Category>(dto));
            var category = CategoryMapper.ToCategory(dto);
            _categoryRepository.addCategory(category);
        }

        public CategoryDto getCategory(int id)
        {
            //return _mapper.Map<CategoryDto>(_categoryRepository.getCategory(id));
            var dto = _categoryRepository.getCategory(id);
            return CategoryMapper.ToCategoryDto(dto);
        }

        public List<CategoryDto> getCatgories()
        {
            //return _mapper.Map<List<CategoryDto>>(_categoryRepository.getCatgories());
            var categories = _categoryRepository.getCatgories();
            return CategoryMapper.ToCategoriesDto(categories);
        }

        public void removeCategory(int id)
        {
            //_categoryRepository.removeCategory(id);
            _categoryRepository.removeCategory(id);
        }

        public void updateCategory(int id, CategoryDto dto)
        {
            //_categoryRepository.updateCategory(id, _mapper.Map<Category>(dto));
            var category = CategoryMapper.ToCategory(dto);
            _categoryRepository.updateCategory(id, category);
        }
    }
}
