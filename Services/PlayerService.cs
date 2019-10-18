using gregslist.Models;
using gregslist.Repositories;

namespace gregslist.Services
{
    public class PlayerService : BaseApiService<Player, int>
    {
        public PlayerService(PlayerRepository repo) : base(repo)
        {

        }
    }
}