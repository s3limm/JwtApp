using JwtApp.Api.Core.Application.Dto.Auth;
using JwtApp.Api.Core.Application.Features.Queries.Auth.CheckUser;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.CheckUser
{
    public class CheckUserQueryRequestHandler : IRequestHandler<CheckUserQueryRequest, CheckUserResponseDto>
    {
        private readonly IRepository<AppUser> userRepository;
        private readonly IRepository<AppRole> roleRepository;

        public CheckUserQueryRequestHandler(IRepository<AppUser> userRepository, IRepository<AppRole> roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public async Task<CheckUserResponseDto> Handle(CheckUserQueryRequest request, CancellationToken cancellationToken)
        {
            var dto = new CheckUserResponseDto();
            var user = await this.userRepository.GetByFilterAsync(x=>x.UserName == request.UserName && x.Password == request.Password);
        
            if(user == null)
            {
                dto.IsExist = false;
            }
            else
            {
                dto.IsExist = true;
                dto.UserName = user.UserName;
                dto.Password = user.UserName;
                var role = await this.roleRepository.GetByFilterAsync(x=>x.Id == user.AppRoleId);
                dto.Role = role?.Definition;
            }

            return dto;
        }

    }
}
