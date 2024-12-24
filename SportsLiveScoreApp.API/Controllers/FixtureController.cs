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
        public ActionResult<IEnumerable<ListViewModel>> GetList([FromQuery] DateOnly filterDate)
        {
            return Ok(FixtureService.GetList(filterDate));
        }

        [HttpGet("{id}")]
        public ActionResult<DetailsViewModel> Get([FromRoute] int id)
        {
            return Ok(FixtureService.Get(id));
        }
    }
}
