using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string? Definition { get; set; }
    }
}
