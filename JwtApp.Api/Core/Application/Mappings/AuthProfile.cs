using AutoMapper;
using JwtApp.Api.Core.Application.Dto.Auth;
using JwtApp.Api.Core.Domain;
using System.Runtime.CompilerServices;

namespace JwtApp.Api.Core.Application.Mappings
{
    public class AuthProfile:Profile
    {
        public AuthProfile()
        {
            this.CreateMap<AuthListDto,AppUser>().ReverseMap();
        }
    }
}
