using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Auth;
using JwtApp.Api.Core.Application.Features.Queries.Auth.GetAllAuth;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace JwtApp.Api.Core.Application.Features.Handlers.ListAuth
{
    public class GetAllAuthQueryRequestHandler : IRequestHandler<GetAllAuthQueryRequest, List<AuthListDto>>
    {
        private readonly IRepository<AppUser> _repository;
        private readonly IMapper _mapper;

        public GetAllAuthQueryRequestHandler(IRepository<AppUser> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<AuthListDto>> Handle(GetAllAuthQueryRequest request, CancellationToken cancellationToken)
        {
            var auths = await _repository.GetAllAsync();
            return _mapper.Map<List<AuthListDto>>(auths);
            
        }
    }
}
