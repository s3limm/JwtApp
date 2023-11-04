using AutoMapper;
using JwtApp.Api.Core.Application.Features.Commands.Auth.Create;
using JwtApp.Api.Core.Application.Features.Commands.Auth.Delete;
using JwtApp.Api.Core.Application.Features.Commands.Auth.Update;
using JwtApp.Api.Core.Application.Features.Queries.Auth.GetAllAuth;
using JwtApp.Api.Core.Application.Features.Queries.Auth.GetAuthById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;

namespace JwtApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthList()
        {
            var result = await _mediator.Send(new GetAllAuthQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthById(int id)
        {
            var result = await _mediator.Send(new GetAuthByIdQueryRequest(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuth(CreateAuthCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request.UserName);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAuth(DeleteAuthCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAuth(UpdateAuthCommandRequest request)
        {
            var result = _mediator.Send(request);
            return Ok(result);
        }
    }
}
