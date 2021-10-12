using System.Collections.Generic;
using System.Linq;

namespace Behourd
{
    public class Team : ITeam
    {
        List<Player> listPlayer = new List<Player>();


        public int PlayerTeamCount { get; private set; }

        public List<Player> Players { get; private set; }

        public Team(Player player)
        {
            Players = new List<Player> { player };
            PlayerTeamCount++;
        }
        

        public void AddPlayers(Player player)
        {
            listPlayer.Add(player);
            Players.AddRange(listPlayer);
            PlayerTeamCount++;
        }
    }
}

