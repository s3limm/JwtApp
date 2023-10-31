using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Product.DeleteProduct
{
    public class DeleteProductCommandRequest:IRequest
    {
        public DeleteProductCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
