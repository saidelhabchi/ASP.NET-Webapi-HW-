using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.DTO;

namespace ServiceLayer.Service.ProductService
{
    public interface IProductService
    {
        List<ProductDto> getProducts();
        ProductDto getProduct(int id);
        void addProduct(ProductDto dto);
        void removeProduct(int id);
        void updateProduct(int id, ProductDto dto);
    }
}
