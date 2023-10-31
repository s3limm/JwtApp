using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Product.UpdateProduct
{
    public class UpdateProductCommandRequest:IRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
