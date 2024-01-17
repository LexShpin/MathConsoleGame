using MyFirstProgram.Models;

namespace MyFirstProgram;

internal class GameEngine
{
  internal void AdditionGame(string message)  
  {
    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
      Console.Clear();
      Console.WriteLine(message);

      firstNumber = random.Next(1, 100);
      secondNumber = random.Next(1, 100);

      Console.WriteLine($"{firstNumber} + {secondNumber}");
      
      var result = Console.ReadLine();

      result = Helpers.ValidateResult(result);

      if (int.Parse(result) == firstNumber + secondNumber)
      {
        Console.WriteLine("Correct! Type any key to see the next question");
        score++;
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Wrong! Type any key to see the next question");
        Console.ReadLine();
      }

      if (i == 4)
      {
        Console.WriteLine($"Game over! Your score is: {score}. Press any key to go back to the main menu");
        Console.ReadLine();
      }
    }

    Helpers.AddGameToHistory(score, GameType.Addition);
  }

  internal void SubtractionGame(string message)
  {
    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
      Console.Clear();
      Console.WriteLine(message);

      firstNumber = random.Next(1, 100);
      secondNumber = random.Next(1, 100);

      Console.WriteLine($"{firstNumber} - {secondNumber}");
     
      var result = Console.ReadLine();

      result = Helpers.ValidateResult(result);

      if (int.Parse(result) == firstNumber - secondNumber)
      {
        Console.WriteLine("Correct! Type any key to see the next question");
        score++;
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Wrong! Type any key to see the next question");
        Console.ReadLine();
      }

      if (i == 4)
      {
        Console.WriteLine($"Game over! Your score is: {score} Press any key to go back to the main menu");
        Console.ReadLine();
      }
    }

    Helpers.AddGameToHistory(score, GameType.Subtraction);
  }

  internal void MultiplicationGame(string message)
  {
    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
      Console.Clear();
      Console.WriteLine(message);

      firstNumber = random.Next(1, 100);
      secondNumber = random.Next(1, 100);

      Console.WriteLine($"{firstNumber} * {secondNumber}");
      
      var result = Console.ReadLine();

      result = Helpers.ValidateResult(result);

      if (int.Parse(result) == firstNumber * secondNumber)
      {
        Console.WriteLine("Correct! Type any key to see the next question");
        score++;
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Wrong! Type any key to see the next question");
        Console.ReadLine();
      }

      if (i == 4)
      {
        Console.WriteLine($"Game over! Your score is: {score} Press any key to go back to the main menu");
        Console.ReadLine();
      }
    }

    Helpers.AddGameToHistory(score, GameType.Multiplication);
  }

  internal void DivisionGame(string message)
  {
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
      Console.Clear();
      Console.WriteLine(message);

      var divisionNumbers = Helpers.GetDivisionNumbers();
      var firstNumber = divisionNumbers[0];
      var secondNumber = divisionNumbers[1];

      Console.WriteLine($"{firstNumber} / {secondNumber}");
      
      var result = Console.ReadLine();

      result = Helpers.ValidateResult(result);

      if (int.Parse(result) == firstNumber / secondNumber)
      {
        Console.WriteLine("Correct! Type any key to see the next question");
        score++;
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("Wrong! Type any key to see the next question");
        Console.ReadLine();
      }

      if (i == 4)
      {
        Console.WriteLine($"Game over! Your score is: {score} Press any key to go back to the main menu");
        Console.ReadLine();
      }
    }

    Helpers.AddGameToHistory(score, GameType.Division);
  }
}