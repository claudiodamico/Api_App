using Api_App.Data_Access;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api_App.Controllers
{
    [Route("api/equipos")]
    [ApiController]
    public class TeamsController : ControllerBase
    {           
        private readonly ILogger<TeamsController> _logger;
        private readonly Api_AppContext _api_App;

        public TeamsController(ILogger<TeamsController> logger,
            Api_AppContext api_App)
        {
            _logger = logger;
            _api_App = api_App;
        }
        [HttpGet]
        public IActionResult GetTeams()
        {
            var teams = _api_App.Teams.ToList();

            return new JsonResult(teams) { StatusCode = 200 };
        }
    }
}