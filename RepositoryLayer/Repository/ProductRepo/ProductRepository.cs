using RepositoryLayer.Context;
using RepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RepositoryLayer.Repository.ProductRepo
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void addProduct(Product product)
        {
            if(product != null) _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product? getProduct(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public List<Product> getProducts()
        {
            return _context.Products.ToList();
        }

        public void removeProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            if(product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public void updateProduct(int id, Product product)
        {
            var _product = _context.Products.FirstOrDefault(p => p.Id == id);
            if(_product != null) 
            {
                _product.Name = product.Name;
                _product.Description = product.Description;
                _product.Price = product.Price;
                _product.Qte = product.Qte;
                _product.CategoryId = product.CategoryId;
                _context.SaveChanges(true);
            }
        }
    }
}
