using JwtApp.Api.Core.Application.Features.Commands.Category.DeleteCategory;
using JwtApp.Api.Core.Application.Interfaces;
using JwtApp.Api.Core.Domain;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Handlers.DeleteCategory
{
    public class DeleteCategoryCommandRequestHandler : IRequestHandler<DeleteCategoryCommandRequest>
    {
        private readonly IRepository<Category> _repository;

        public DeleteCategoryCommandRequestHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var category = await _repository.GetByIdAsync(request.Id);
            if (category != null)
            {
                await _repository.DeleteAsync(category);
            }
            return Unit.Value;
        }
    }
}
