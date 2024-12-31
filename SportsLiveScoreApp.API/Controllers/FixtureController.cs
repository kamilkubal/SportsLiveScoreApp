using Microsoft.AspNetCore.Mvc;
using SportsLiveScoreApp.Application.Models.ViewModels.Fixtures;
using SportsLiveScoreApp.Application.Services.Fixtures;

namespace SportsLiveScoreApp.API.Controllers
{
    [ApiController]
    [Route("fixture")]
    public class FixtureController : ControllerBase
    {
        public FixtureService FixtureService { get; }

        public FixtureController(FixtureService fixtureService)
        {
            FixtureService = fixtureService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ListViewModel>> GetList([FromQuery]DateOnly? filterDate)
        {
            if (filterDate == null)
                return BadRequest("Date time is not valid");

            return Ok(FixtureService.GetList(filterDate.Value));
        }

        [HttpGet("{id}")]
        public ActionResult<DetailsViewModel> Get([FromRoute]int? id)
        {
            if (!id.HasValue || id <= 0)
                return NotFound("Value 'Id' has not found");

            return Ok(FixtureService.Get(id));
        }
    }
}
