using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Category;
using JwtApp.Api.Core.Domain;

namespace JwtApp.Api.Core.Application.Mappings
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            this.CreateMap<Category, CategoryListDto>().ReverseMap();
        }
    }
}
