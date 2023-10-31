using JwtApp.Api.Core.Application.Features.Commands.Product.CreateProduct;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.CreateProduct
{
    public class CreateProductCommandRequestHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;
        public CreateProductCommandRequestHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product { Name = request.Name, Stock = request.Stock, Price = request.Price, CategoryId = request.CategoryId });
            return Unit.Value;
        }
    }
}
