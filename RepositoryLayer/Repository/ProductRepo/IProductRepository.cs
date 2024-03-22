using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Model;

namespace RepositoryLayer.Repository.ProductRepo
{
    public interface IProductRepository
    {
        List<Product> getProducts();
        Product? getProduct(int id);
        void addProduct(Product product);
        void removeProduct(int id);
        void updateProduct(int id, Product product);
    }
}
