using JwtApp.Api.Core.Application.Dto.Category;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Category.GetCategoryById
{
    public class GetCategoryByIdQueryRequest:IRequest<CategoryListDto>
    {
        public GetCategoryByIdQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
