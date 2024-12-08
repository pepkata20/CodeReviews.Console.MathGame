using System.Diagnostics;

internal class Game
{

    public DateTime Date { get; set; }

    public int Score { get; set; } = 0;

    public GameType Type { get; set; }

    public Difficulty Difficulty { get; set; }

    public Stopwatch Stopwatch { get; set; } = new Stopwatch();

}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}
internal enum Difficulty
{
    Easy,
    Normal,
    Hard,
    VeryHard
}
