using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RepositoryLayer.Context;
using RepositoryLayer.Repository.CategoryRepo;
using RepositoryLayer.Repository.ProductRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositoryLayer(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"), b => b.MigrationsAssembly("ProductManagementAPI"));
                
                });
        }
    }
}
