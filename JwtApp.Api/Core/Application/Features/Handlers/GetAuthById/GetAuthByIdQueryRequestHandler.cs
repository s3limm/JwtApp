using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Auth;
using JwtApp.Api.Core.Application.Features.Queries.Auth.GetAuthById;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.GetAuthById
{
    public class GetAuthByIdQueryRequestHandler : IRequestHandler<GetAuthByIdQueryRequest, AuthListDto>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;
        public GetAuthByIdQueryRequestHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<AuthListDto> Handle(GetAuthByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var user = await _repository.GetByFilterAsync(x=>x.Id == request.Id);
            return _mapper.Map<AuthListDto>(user);
        }
    }
}
