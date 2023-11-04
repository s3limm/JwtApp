using JwtApp.Api.Core.Application.Features.Commands.Auth.Create;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.CreateAuth
{
    public class CreateAuthCommandRequestHandler : IRequestHandler<CreateAuthCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public CreateAuthCommandRequestHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateAuthCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new AppUser
            {
                UserName = request.UserName,
                Password = request.Password,
                AppRoleId = request.AppRoleId
            });
            return Unit.Value;
        }
    }
}
