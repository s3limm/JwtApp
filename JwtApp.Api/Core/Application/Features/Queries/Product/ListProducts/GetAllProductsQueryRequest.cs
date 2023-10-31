using JwtApp.Api.Core.Application.Dto.Product;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Product.ListProducts
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
    {

    }
}
