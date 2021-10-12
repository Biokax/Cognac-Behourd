using System.Collections.Generic;
using System.Linq;
namespace Behourd
{
    public interface ITeam
    {
        //List<Player> _players { get; }
        //int PlayerCount { get; }
        int PlayerTeamCount { get; }

        Player[] Players { get; }
    }
}
