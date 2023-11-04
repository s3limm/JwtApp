using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Auth.Register
{
    public class RegisterCommandRequest:IRequest
    {
        public string UserName { get; set; }
        public int Password { get; set; }
    }
}
