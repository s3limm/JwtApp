using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Category.DeleteCategory
{
    public class DeleteCategoryCommandRequest:IRequest
    {
        public DeleteCategoryCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
