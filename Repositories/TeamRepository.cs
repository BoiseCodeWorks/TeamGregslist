using System.Data;
using gregslist.Models;

namespace gregslist.Repositories
{
    public class TeamRepository : BaseApiRepository<Team, int>
    {
        public TeamRepository(IDbConnection db) : base(db, "teams")
        {
        }

        public int Create(Team newTeam)
        {
            //custom sql here
            return 0;
        }
    }
}