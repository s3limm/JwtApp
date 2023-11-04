using JwtApp.Api.Core.Application.Dto.Auth;
using MediatR;

namespace JwtApp.Api.Core.Application.Features.Queries.Auth.GetAuthById
{
    public class GetAuthByIdQueryRequest:IRequest<AuthListDto>
    {
        public int Id { get; set; }
        public GetAuthByIdQueryRequest(int id)
        {
            Id = id;
        }
    }
}
