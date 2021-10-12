namespace Behourd
{
    public interface ITeam
    {
        int PlayerCount { get; }
        int TeamCount { get; }

        Player[] Players { get; }
    }
}
