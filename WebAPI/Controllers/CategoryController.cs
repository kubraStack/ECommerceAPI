using Application.Features.Category.Commands.AssingCategoryToProductCommand;
using Application.Features.Category.Commands.CreateCategory;
using Application.Features.Category.Commands.DeleteCategory;
using Application.Features.Category.Commands.RemoveCategoryFromProductCommand;
using Application.Features.Category.Commands.UpdateCategory;
using Application.Features.Category.Queries.GetAllCategories;
using Application.Features.Category.Queries.GetByIdCategory;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create-Category")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var category = await _mediator.Send(createCategoryCommand);
            return Ok(category);
        }

        [HttpGet("All-Category")]
        public async Task<IActionResult> GetAllCategories()
        {
            var query = new GetAllCategoryQuery();
            var result = await _mediator.Send(query);   
            return Ok(result);
        }

        [HttpGet("GetByIdCategory/{id}")]
        public async Task<IActionResult> GetByIdCategory(int id)
        {
            var query = new GetByIdCategoryQuery(id);
            var category = await _mediator.Send(query);
            return Ok(category);
        }

        [HttpDelete("Delete-Category/{id}")]
        public async Task<IActionResult> DeleteCategory(int id) {

            var command = new DeleteCategoryCommand(id);
            var result = await _mediator.Send(command);
            return Ok(result);
        
        }
        [HttpPut("Update-Category")]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryCommand updateCategoryCommand)
        {
            var response = await _mediator.Send(updateCategoryCommand);
            return Ok(response);
        }

        [HttpPost("Assign-Category-ToProduct")]
        public async Task<IActionResult> AssingCategoryToProduct([FromBody] AssingCategoryToProductCommand assignCategoryCommand)
        {
            var response = await _mediator.Send(assignCategoryCommand);
            return Ok(response);
        }

        [HttpDelete("Remove-Category-FromProduct")]
        public async Task<IActionResult> RemoveCategoryFromProduct([FromBody] RemoveCategoryFromProductCommand removeCategoryFromProductCommand)
        {
            var result = await _mediator.Send(removeCategoryFromProductCommand);
            return Ok(result);
        }
    }
}
