namespace Behourd
{
   public class Team : ITeam
            {
                public int PlayerCount => 1;
                public int TeamCount => 2;
                public Player[] Players { get; }

                public Team(Player player)
                {
                    Players = new Player[] { player };
                }
            }
}
