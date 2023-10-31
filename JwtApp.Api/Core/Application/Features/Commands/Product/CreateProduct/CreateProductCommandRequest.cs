using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Product.CreateProduct
{
    public class CreateProductCommandRequest:IRequest
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
