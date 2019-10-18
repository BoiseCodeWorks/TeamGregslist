using gregslist.Models;
using gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregslist.Controllers
{
    [Route("/api/[controller]")]
    public class PlayerController : BaseApiController<Player, int>
    {
        public PlayerController(BaseApiService<Player, int> ts) : base(ts)
        { }
    }
}