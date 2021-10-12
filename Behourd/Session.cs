using System.Collections.Generic;
using System.Linq;

namespace Behourd
{
    public class Session
    {
        public int PlayerSessionCount { get; private set; }

        private readonly List<Player> _players = new();

        public void AddPlayers(params Player[] players)
        {
            _players.AddRange(players);

            PlayerSessionCount += players.Length;
        }


        public IGame StartGame()
        {
            return new Game(_players);
        }

        
    }
}
