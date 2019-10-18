using System.Collections.Generic;
using gregslist.Models;
using gregslist.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [Route("/api/[controller]")]
    public class TeamController : BaseApiController<Team, int>
    {
        public TeamController(TeamService ts) : base(ts)
        { }

        // [Authorize]
        // [HttpGet]
        // public override ActionResult<IEnumerable<Team>> Get()
        // {

        // }
    }
}