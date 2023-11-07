using JwtApp.Api.Core.Application.Dto.Auth;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Auth.CheckUser
{
    public class CheckUserQueryRequest:IRequest<CheckUserResponseDto>
    {
        public string UserName { get; set; }
        public int Password { get; set; }

    }
}
