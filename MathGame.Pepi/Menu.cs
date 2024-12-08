namespace Academy_Math_Game;

internal class Menu
{
    internal static void MainMenu()
    {
        bool continueGame = true;

        do
        {
            Console.Clear();
            Console.WriteLine("What game would you like to play today? Choose from the options below:");
            Console.WriteLine();

            Console.WriteLine("A - Addition");
            Console.WriteLine("S - Subtraction");
            Console.WriteLine("M - Multiplication");
            Console.WriteLine("D - Divison");
            Console.WriteLine("P - Print previous games");
            Console.WriteLine("R - Random Games");
            Console.WriteLine("Q - Quit");


            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");


            var menuSelection = Console.ReadLine().ToUpper().Trim();
            var game = new Operations();
            var counter = 0;
            Difficulty difficulty = new Difficulty();

            switch (menuSelection)
            {
                case "A":
                    difficulty = ChooseDifficulty();
                    Operations.Game(GameType.Addition, difficulty);
                    break;

                case "S":
                    difficulty = ChooseDifficulty();

                    Operations.Game(GameType.Subtraction, difficulty);
                    break;

                case "M":
                    difficulty = ChooseDifficulty();

                    Operations.Game(GameType.Multiplication, difficulty);
                    break;

                case "D":
                    difficulty = ChooseDifficulty();

                    Operations.Game(GameType.Division, difficulty);
                    break;

                case "R":
                    difficulty = ChooseDifficulty();
                    Operations.Game(GameType.Addition, difficulty, true);
                    break;

                case "Q":
                    continueGame = false;
                    break;

                case "P":
                    Helpers.PrintGames();
                    break;

                default:
                    break;
            }
        } while (continueGame);
        Console.WriteLine("Game Exited");
    }
    internal static Difficulty ChooseDifficulty()
    {
        Console.Clear();
        Console.WriteLine("Choose a difficulty:");
        Console.WriteLine();
        Console.WriteLine("1");
        Console.WriteLine("2");
        Console.WriteLine("3");
        Console.WriteLine("4");
        Console.WriteLine();
        Console.WriteLine("---------------------------------------------");

        var difficulty = new Difficulty();
        var menuSelection = Console.ReadLine().Trim();
        switch (menuSelection)
        {
            case "1":
                difficulty = Difficulty.Easy;
                break;
            case "2":
                difficulty = Difficulty.Normal;

                break;
            case "3":
                difficulty = Difficulty.Hard;

                break;
            case "4":
                difficulty = Difficulty.VeryHard;

                break;
            default:
                break;
        }
        return difficulty;
    }
}
