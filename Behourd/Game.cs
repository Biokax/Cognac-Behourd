using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behourd
{
    public class Game : IGame
    {
        public ITeam[] Teams { get; }

        public Game(IEnumerable<Player> players)
        {
            Teams = players.Select(player => new Team(player)).ToArray();
        }
    }
}
