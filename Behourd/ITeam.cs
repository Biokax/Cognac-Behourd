using System.Collections.Generic;
using System.Linq;
namespace Behourd
{
    public interface ITeam
    {
        int PlayerTeamCount { get; }

        List<Player> Players { get; }
    }
}
