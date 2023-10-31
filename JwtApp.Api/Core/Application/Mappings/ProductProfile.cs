using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Category;
using JwtApp.Api.Core.Application.Dto.Product;
using JwtApp.Api.Core.Domain;

namespace JwtApp.Api.Core.Application.Mappings
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            this.CreateMap<Product, ProductListDto>().ReverseMap();
           
        }
    }
}
