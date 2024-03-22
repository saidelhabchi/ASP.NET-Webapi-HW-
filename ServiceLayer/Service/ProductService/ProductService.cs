using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Repository;
using RepositoryLayer.Repository.ProductRepo;
using ServiceLayer.Mapper;
using ServiceLayer.DTO;
using AutoMapper;
using RepositoryLayer.Model;
using RepositoryLayer.Repository.CategoryRepo;
namespace ServiceLayer.Service.ProductService
{
    internal class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        //private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            //_mapper = mapper;
        }

        public void addProduct(ProductDto dto)
        {
            //_productRepository.addProduct(_mapper.Map<Product>(dto));
            var product = ProductMapper.ToProduct(dto);
            var category = _categoryRepository.getCategory(dto.CategoryId);
            product.Category = category;
            _productRepository.addProduct(product);
        }

        public ProductDto getProduct(int id)
        {
            //return _mapper.Map<ProductDto>(_productRepository.getProduct(id));
            var product = _productRepository.getProduct(id);
            return ProductMapper.ToProductDto(product);
        }

        public List<ProductDto> getProducts()
        {
            //return _mapper.Map<List<ProductDto>>(_productRepository.getProducts());
            var products = _productRepository.getProducts();
            return ProductMapper.ToProductDtos(products);
        }

        public void removeProduct(int id)
        {
            //_productRepository.removeProduct(id);
            _productRepository.removeProduct(id);
        }

        public void updateProduct(int id, ProductDto dto)
        {
            //_productRepository.updateProduct(id, _mapper.Map<Product>(dto));
            var product = ProductMapper.ToProduct(dto);
            _productRepository.updateProduct(id, product);
        }
    }
}
