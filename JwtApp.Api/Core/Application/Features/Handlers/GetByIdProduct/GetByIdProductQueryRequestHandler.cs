
using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Product;
using JwtApp.Api.Core.Application.Features.Queries.Product.GetByIdProduct;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Api.Core.Application.Features.Handlers.GetByIdProductQueryRequestHandler
{
    public class GetByIdProductQueryRequestHandler : IRequestHandler<GetByIdProductQueryRequest, ProductListDto>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetByIdProductQueryRequestHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductListDto> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByFilterAsync(x=>x.ID == request.Id);
            return _mapper.Map<ProductListDto>(product);
        }
    }
}
