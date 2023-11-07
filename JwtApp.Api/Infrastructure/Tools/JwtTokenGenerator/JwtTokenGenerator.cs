﻿using JwtApp.Api.Core.Application.Dto.Auth;
using JwtApp.Api.Core.Application.Dto.Token;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtApp.Api.Infrastructure.Tools.JwtTokenGenerator
{
    public class JwtTokenGenerator
    {
        public static TokenResponseDto GenerateToken(CheckUserResponseDto dto)
        {
            var claims = new List<Claim>();

            if (!string.IsNullOrEmpty(dto.Role))
                claims.Add(new Claim(ClaimTypes.Role,dto.Role));

            if (!string.IsNullOrEmpty(dto.UserName))
                claims.Add(new Claim("UserName", dto.UserName));

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.JwtTokenDefaults.Key));
           
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
           
            var expireTime = DateTime.UtcNow.AddMinutes(5);
           
            JwtSecurityToken token = new JwtSecurityToken(issuer: JwtTokenDefaults.JwtTokenDefaults.ValidIssuer, audience: JwtTokenDefaults.JwtTokenDefaults.ValidAudience,
                notBefore: DateTime.UtcNow, expires: expireTime, signingCredentials: credentials,claims:claims);
            
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
           
            return new TokenResponseDto(handler.WriteToken(token),expireTime);
        }
    }
}
