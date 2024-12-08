using System.Diagnostics;

namespace Academy_Math_Game;

internal class Operations
{
    internal static void Game(GameType gameType, Difficulty difficulty, bool randomGame = false)
    {
        Console.Clear();

        Random random = new Random();
        var stopwatch = new Stopwatch();

        int gameCounter = 0;
        int score = 0;
        int randomNumber1 = 0;
        int randomNumber2 = 0;
        int answer = 0;

        char operationMsg = '+';
        string message = "";

        int low = 1;
        int high = 0;



        switch (difficulty)
        {
            case Difficulty.Easy:
                high = 10;

                break;
            case Difficulty.Normal:
                high = 20;

                break;
            case Difficulty.Hard:
                high = 50;

                break;
            case Difficulty.VeryHard:
                high = 100;

                break;
            default:
                break;
        }


        stopwatch.Restart();
        do
        {
            if (randomGame)
            {
                Array values = Enum.GetValues(typeof(GameType));  
                gameType = (GameType)values.GetValue(random.Next(0, values.Length - 1));
            }

            switch (gameType)
            {
                case GameType.Addition:
                    randomNumber1 = random.Next(low, high);
                    randomNumber2 = random.Next(low, high);
                    answer = randomNumber1 + randomNumber2;
                    operationMsg = '+';
                    break;
                case GameType.Subtraction:
                    randomNumber1 = random.Next(low, high);
                    randomNumber2 = random.Next(low, high);
                    answer = randomNumber1 - randomNumber2;
                    operationMsg = '-';
                    break;
                case GameType.Multiplication:
                    randomNumber1 = random.Next(low, high);
                    randomNumber2 = random.Next(low, high);
                    answer = randomNumber1 * randomNumber2;
                    operationMsg = '*';
                    break;
                case GameType.Division:
                    randomNumber1 = random.Next(low, high);
                    randomNumber2 = random.Next(low, high);

                    while (randomNumber1 % randomNumber2 != 0 || randomNumber1 / randomNumber2 == 1 || randomNumber2 == 1)
                    {
                        randomNumber1 = random.Next(low, high);
                        randomNumber2 = random.Next(low, high);
                    }
                    answer = randomNumber1 / randomNumber2;
                    operationMsg = '/';
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{randomNumber1} {operationMsg} {randomNumber2}:");
            string? userInput = Console.ReadLine();

            var userNumber = Helpers.ValidateInput(userInput);

            if (userNumber == answer)
            {
                message = "Correct answer!";
                score++;
            }
            else
            {
                message = "Wrong answer :(.";
            }
            gameCounter++;

            Console.WriteLine(message);
        } while (gameCounter < 5);
        stopwatch.Stop();

        if (randomGame)
            Helpers.AddToHistory(GameType.Random, score, difficulty, stopwatch);
        else
            Helpers.AddToHistory(gameType, score, difficulty, stopwatch);

        Console.WriteLine($"Final Score: {score}");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    } 
}
