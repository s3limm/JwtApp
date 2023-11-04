using MediatR;

namespace JwtApp.Api.Core.Application.Features.Commands.Auth.Update
{
    public class UpdateAuthCommandRequest:IRequest
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public int AppRoleId { get; set; }
    }
}
