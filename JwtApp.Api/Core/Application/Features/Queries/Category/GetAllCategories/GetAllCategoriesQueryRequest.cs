using JwtApp.Api.Core.Application.Dto.Category;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Category.GetAllCategories
{
    public class GetAllCategoriesQueryRequest:IRequest<List<CategoryListDto>>
    {
    }
}
