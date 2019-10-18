using System.Data;
using gregslist.Models;

namespace gregslist.Repositories
{
    public class PlayerRepository : BaseApiRepository<Player, int>
    {
        public PlayerRepository(IDbConnection db) : base(db, "players")
        {
        }

        public int Create(Team newTeam)
        {
            //custom sql here
            return 0;
        }
    }
}