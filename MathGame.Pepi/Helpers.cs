using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace Academy_Math_Game;

internal static class Helpers
{
    internal static int ValidateInput(string userNumber)
    {
        int validatedOutput = 0;
        while (userNumber == null || !int.TryParse(userNumber, out validatedOutput))
        {
            Console.WriteLine("Invalid input, please enter a number:");
            userNumber = Console.ReadLine();
        }
        return validatedOutput;
    }

    internal static void AddToHistory(GameType gameType, int score, Difficulty difficulty, Stopwatch stopwatch)
    {
        games.Add(new Game { Date = DateTime.Now, Type = gameType, Score = score, Difficulty = difficulty, Stopwatch = stopwatch});
    }
    
    internal static void PrintGames()
    {
        Console.Clear();
        foreach (var game in games)
        {
            Console.WriteLine($"Date: {game.Date}, Type: {game.Type}, Score: {game.Score}, Difficulty: {game.Difficulty}, Time: {game.Stopwatch.Elapsed:mm\\:ss\\:ff}");
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    internal static List<Game> games = new List<Game>
    {
        new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
        new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
        /*new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
        new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
        new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
        new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
        new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
        new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },*/

    };
}


