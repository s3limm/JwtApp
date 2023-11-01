using JwtApp.Api.Core.Application.Features.Commands.Category.CreateCategory;
using JwtApp.Api.Core.Application.Features.Commands.Category.DeleteCategory;
using JwtApp.Api.Core.Application.Features.Commands.Category.UpdateCategory;
using JwtApp.Api.Core.Application.Features.Handlers.CreateCategory;
using JwtApp.Api.Core.Application.Features.Queries.Category.GetAllCategories;
using JwtApp.Api.Core.Application.Features.Queries.Category.GetCategoryById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllCategory()
        {
            var result = await _mediator.Send(new GetAllCategoriesQueryRequest());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> CategoryGetById(int id)
        {
            var category = await _mediator.Send(new GetCategoryByIdQueryRequest(id));
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Created("", request.Definition);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(DeleteCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok();
        }


    }
}
