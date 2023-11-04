using JwtApp.Api.Core.Application.Dto.Auth;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Auth.GetAllAuth
{
    public class GetAllAuthQueryRequest:IRequest<List<AuthListDto>>
    {

    }
}
