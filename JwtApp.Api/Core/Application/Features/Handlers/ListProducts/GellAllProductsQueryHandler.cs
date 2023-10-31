using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Product;
using JwtApp.Api.Core.Application.Features.Queries.Product;
using JwtApp.Api.Core.Application.Features.Queries.Product.ListProducts;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.ListProducts
{
    public class GellAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;
        public GellAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            return _mapper.Map<List<ProductListDto>>(data);
        }
    }
}
