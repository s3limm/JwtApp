using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Auth.Create
{
    public class CreateAuthCommandRequest : IRequest
    {
        public string UserName { get; set; }
        public int Password { get; set; }
        public int AppRoleId { get; set; }
    }
}
