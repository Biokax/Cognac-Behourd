using System.Collections.Generic;
using System.Linq;

namespace Behourd
{
    public class Team : ITeam
    {
        List<Player> listPlayer = new List<Player>();


        public int PlayerTeamCount { get; private set; }

        public Player[] Players { get; }

        public Team(Player player)
        {
            Players = new Player[] { player };
            PlayerTeamCount++;
        }
        

        public void AddPlayers(params Player[] players)
        {
            listPlayer.AddRange(players);
            PlayerTeamCount++;
        }
    }
}

