using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Auth.Delete
{
    public class DeleteAuthCommandRequest:IRequest
    {
        public DeleteAuthCommandRequest(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
