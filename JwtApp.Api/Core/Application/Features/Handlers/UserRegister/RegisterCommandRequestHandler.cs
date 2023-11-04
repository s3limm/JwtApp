using JwtApp.Api.Core.Application.Enums;
using JwtApp.Api.Core.Application.Features.Commands.Auth.Register;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.UserRegister
{
    public class RegisterCommandRequestHandler : IRequestHandler<RegisterCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public RegisterCommandRequestHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(RegisterCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                UserName = request.UserName,
                Password = request.Password,
                AppRoleId = (int)RoleType.Member
            });
            return Unit.Value;
        }
    }
}
