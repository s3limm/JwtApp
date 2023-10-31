using JwtApp.Api.Core.Application.Dto.Product;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Product.GetByIdProduct
{
    public class GetByIdProductQueryRequest : IRequest<ProductListDto>
    {
        public GetByIdProductQueryRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
