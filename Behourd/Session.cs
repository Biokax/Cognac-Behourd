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

        
    }
}
