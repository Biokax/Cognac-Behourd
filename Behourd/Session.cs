using System.Collections.Generic;
using System.Linq;

namespace Behourd
{
    public class Session
    {
        private readonly List<Player> _players = new();

        public void AddPlayers(params Player[] players)
        {
            _players.AddRange(players);
        }

        public IGame StartGame()
        {
            return new Game(_players);
        }

        private class Game : IGame
        {
            public ITeam[] Teams { get; }

            public Game(IEnumerable<Player> players)
            {
                Teams = players.Select(player => new Team(player)).ToArray();
            }

            private class Team : ITeam
            {
                public int PlayerCount => 1;
                public Player[] Players { get; }

                public Team(Player player)
                {
                    Players = new Player[] { player };
                }
            }
        }
    }
}
