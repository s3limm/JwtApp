using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandRequest : IRequest
    {
        public string? Definition { get; set; }
    }
}
