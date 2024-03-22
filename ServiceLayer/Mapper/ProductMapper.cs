using RepositoryLayer.Model;
using ServiceLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapper
{
    public static class ProductMapper
    {
        public static ProductDto ToProductDto(Product product) 
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Qte = product.Qte,
                CategoryId = product.CategoryId,
            };
        }
        public static Product ToProduct(ProductDto product) 
        {
            return new Product
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Qte = product.Qte,
                CategoryId = product.CategoryId
            };
        }
        /*
        public static Product ToProduct(CreateProductDto dto)
        {
            return new Product { Name = dto.Name };
        }
        public static Product ToProduct(UpdateProductDto dto)
        {
            return new Product { Name = dto.Name, Description = dto.Description, Price = dto.Price, Qte = dto.Qte, CategoryId = dto.CategoryId };
        }
        */
        public static List<Product> ToProducts(List<ProductDto> dtos) 
        {
            if (dtos == null)
            {
                return new List<Product>();
            }
            return dtos.Select(p => ToProduct(p)).ToList();
        }
        public static List<ProductDto> ToProductDtos(List<Product> products)
        {
            if (products == null)
            {
                return new List<ProductDto>();
            }
            return products.Select(p => ToProductDto(p)).ToList();
        }
    }
}
