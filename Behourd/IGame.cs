namespace Behourd
{
    public interface IGame
    {
        int TeamCount { get; }

        ITeam[] Teams { get; }
    }
}
