using JwtApp.Api.Core.Application.Features.Commands.Product.DeleteProduct;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.DeleteProduct
{
    public class DeleteProductCommandRequestHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public DeleteProductCommandRequestHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(product);
            return Unit.Value;
        }
    }
}
