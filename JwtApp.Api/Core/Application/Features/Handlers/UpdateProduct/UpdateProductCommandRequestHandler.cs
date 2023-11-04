using JwtApp.Api.Core.Application.Features.Commands.Product.UpdateProduct;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.UpdateProduct
{
    public class UpdateProductCommandRequestHandler : IRequestHandler<UpdateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;
        public UpdateProductCommandRequestHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.ID);
            if (product != null)
            {
                product.Name = request.Name;
                product.Price = request.Price;
                product.Stock = request.Stock;
                product.CategoryId = request.CategoryId;
            }
            await _repository.UpdateAsync(product);
            return Unit.Value;
        }
    }
}
