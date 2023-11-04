using JwtApp.Api.Core.Application.Features.Commands.Auth.Update;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.UpdateAuth
{
    public class UpdateAuthCommandRequestHandler : IRequestHandler<UpdateAuthCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public UpdateAuthCommandRequestHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateAuthCommandRequest request, CancellationToken cancellationToken)
        {
            var updatedUser = await _repository.GetByIdAsync(request.Id);
            if (updatedUser == null)
            {
                updatedUser.UserName = request.UserName;
                updatedUser.Password = request.Password;
                updatedUser.AppRoleId = request.AppRoleId;
            }
            await _repository.UpdateAsync(updatedUser);
            return Unit.Value;
        }
    }
}
