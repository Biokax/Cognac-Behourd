namespace Behourd
{
    public interface ITeam
    {
        int PlayerCount { get; }

        Player[] Players { get; }
    }
}
