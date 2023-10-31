using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Category;
using JwtApp.Api.Core.Application.Features.Queries.Category.GetAllCategories;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;
using System.Runtime.CompilerServices;

namespace JwtApp.Api.Core.Application.Features.Handlers.GetAllCategory
{
    public class GetAllCategoriesQueryRequestHandler : IRequestHandler<GetAllCategoriesQueryRequest, List<CategoryListDto>>
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetAllCategoriesQueryRequestHandler(IRepository<Category> repository, IMapper mapper = null)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoryListDto>> Handle(GetAllCategoriesQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            return _mapper.Map<List<CategoryListDto>>(data);
        }
    }
}
