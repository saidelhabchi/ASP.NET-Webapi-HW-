using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Service.CategoryService;
using ServiceLayer.Service.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServiceLayer(this IServiceCollection services) 
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
