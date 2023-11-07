using JwtApp.Api.Core.Application.Features.Commands.Product.CreateProduct;
using JwtApp.Api.Core.Application.Features.Commands.Product.DeleteProduct;
using JwtApp.Api.Core.Application.Features.Commands.Product.UpdateProduct;
using JwtApp.Api.Core.Application.Features.Handlers.CreateProduct;
using JwtApp.Api.Core.Application.Features.Queries.Product;
using JwtApp.Api.Core.Application.Features.Queries.Product.GetByIdProduct;
using JwtApp.Api.Core.Application.Features.Queries.Product.ListProducts;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Api.Controllers
{
    [Authorize(Roles ="Admin")]
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

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request.Name);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProduct(int id)
        {
            var product = await _mediator.Send(new GetByIdProductQueryRequest(id));
            return product == null ? NotFound() : Ok(product); 
        }
    }
}
