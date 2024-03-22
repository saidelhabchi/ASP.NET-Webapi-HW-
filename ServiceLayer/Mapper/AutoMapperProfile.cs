using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Model;
using ServiceLayer.DTO;

namespace ServiceLayer.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();


            CreateMap<List<Category>, List<CategoryDto>>().ReverseMap();
            CreateMap<List<ProductDto>, List<Product>>().ReverseMap();
        }
    }
}
