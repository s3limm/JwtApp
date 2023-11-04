using JwtApp.Api.Core.Application.Features.Commands.Auth.Delete;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.DeleteAuth
{
    public class DeleteAuthCommandRequestHandler : IRequestHandler<DeleteAuthCommandRequest>
    {
        private readonly IRepository<AppUser> _repository;

        public DeleteAuthCommandRequestHandler(IRepository<AppUser> repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(DeleteAuthCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedUser = await _repository.GetByIdAsync(request.Id);
            if (deletedUser != null)
            {
                await _repository.DeleteAsync(deletedUser);
            }
            return Unit.Value;
        }
    }
}
