using Application.Features.Categories.Commands.CreateCategory;
using Application.Features.Categories.Queries.GetCategoriesList;
using Application.Features.Categories.Queries.GetCategoriesList.DTOs;
using Application.Features.Categories.Queries.GetCategoriesListWithTrips;
using Application.Features.Categories.Queries.GetCategoriesListWithTrips.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
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

        [HttpGet("", Name = "GetAllCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryListResponse>>> GetAllCategories()
        {
            var categories = await _mediator.Send(new GetCategoryListQuery());
            return Ok(categories);
        }

        [HttpGet("withTrips", Name = "GetCategoriesWithTrips")]
        [ProducesDefaultResponseType]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CategoryTripListResponse>>> GetCategoriesWithTrips(bool includePassedTrips)
        {
            GetCategoryListWithTripsQuery getCategoryListWithTripsQuery = new GetCategoryListWithTripsQuery() { IncludePassedTrips = includePassedTrips };

            var categories = await _mediator.Send(getCategoryListWithTripsQuery);
            return Ok(categories);
        }

        [HttpPost(Name = "CreateCategory")]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var response = await _mediator.Send(createCategoryCommand);
            return Ok(response);
        }
    }
}
