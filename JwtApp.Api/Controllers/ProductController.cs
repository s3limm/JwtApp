using JwtApp.Api.Core.Application.Features.Queries.Product;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListProducts()
        {
            var result = await _mediator.Send(new GetAllProductsQueryRequest());
            return Ok(result);
        }
    }
}
