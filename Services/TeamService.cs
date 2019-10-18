using gregslist.Models;
using gregslist.Repositories;

namespace gregslist.Services
{
    public class TeamService : BaseApiService<Team, int>
    {
        public TeamService(TeamRepository repo) : base(repo)
        {

        }
    }
}