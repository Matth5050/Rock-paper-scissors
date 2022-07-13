using System;
using ToDoList.Models;

namespace Game
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("ROCK PAPER SCISSORS!!!!!!!");
      Console.WriteLine("Player One choose: (Rock/Paper/Scissors)");
      string p1Response = Console.ReadLine();
      Console.WriteLine("Player Two choose: (Rock/Paper/Scissors)");
      string p2Response = Console.ReadLine();

      if (p1Response == "Rock" && p2Response == "Rock" || p1Response == "Paper" && p2Response == "Paper" || p1Response == "Scissors" && p2Response == "Scissors")
      {
        Console.WriteLine("Draw!");
      }
      else if (p1Response == "Rock" && p2Response == "Scissors" ||p1Response == "Paper" && p2Response == "Rock" || p1Response == "Scissors" && p2Response == "Paper")
      {
        Console.WriteLine("Player One Wins!");
      }
      else if (p1Response == "Scissors" && p2Response == "Rock" || p1Response == "Rock" && p2Response == "Paper" || p1Response == "Paper" && p2Response == "Scissors")
      {
        Console.WriteLine("Player Two Wins!");
      }
      else
      {
        Console.WriteLine("No losers at epicodus");
      }
    }
  }
}