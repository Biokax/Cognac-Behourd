using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behourd
{
    public class Game : IGame
    {
        public int TeamCount { get; private set; }
        public ITeam[] Teams { get; }
        List<Team> listTeam = new List<Team>();


        public Game(IEnumerable<Player> players)
        {


            foreach(Player player in players)
            {
                if (TeamCount < 2)
                {
                    listTeam.Add(new Team(player));
                    TeamCount++;

                }else
                {
                    //TODO
                }
            }
            Teams = listTeam.ToArray();
        }
    }
}
