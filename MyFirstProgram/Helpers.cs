using MyFirstProgram.Models;

namespace MyFirstProgram;

internal class Helpers
{
  internal static List<Game> games = new();
  
  internal static int[] GetDivisionNumbers()
  {
    Random random = new Random();
    int firstNumber = random.Next(1, 100);
    int secondNumber = random.Next(1, 100);

    int[] result = new int[2];
  
    while (firstNumber % secondNumber != 0)
    {
      firstNumber = random.Next(1, 100);
      secondNumber = random.Next(1, 100);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;
  
    return result;
  }

  internal static void PrintGames()
  {
    Console.Clear();
    Console.WriteLine("Games History");
    Console.WriteLine("----------------------");
    foreach (var game in games)
    {
      Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
    }

    Console.WriteLine("--------------------------\n");
    Console.WriteLine("Press any key to return to Main Menu");
    Console.ReadLine();
  }

  internal static void AddGameToHistory(int score, GameType gameType)
  {
    games.Add(new Game
    {
      Date = DateTime.Now,
      Score = score,
      Type = gameType
    });
  }

  internal static string? ValidateResult(string result)
  {
    while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
    {
      Console.WriteLine("Your answer needs to be an integer, try again");
      result = Console.ReadLine();
    }

    return result;
  }
  
  internal static string GetName()
  {
    Console.WriteLine("Please type your name:");
    string name = Console.ReadLine();

    while (string.IsNullOrEmpty(name))
    {
      Console.WriteLine("Name can't be empty");
      name = Console.ReadLine();
    }
    
    return name;
  }
}

