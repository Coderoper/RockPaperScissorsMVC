using System.Collections.Generic;
using System.IO;
using System;
namespace RockPaperScissorsApp.Models
{
  public class RockPaperScissors
  {
    public bool GetWinner(string PlayerOne, string PlayerTwo)
    {
      if (PlayerOne == null || PlayerTwo == null)
      {
        Console.WriteLine("Both players must select an option");
        return true;
      }
      else if (PlayerOne == PlayerTwo)
      {
        Console.WriteLine("It's a tie!");
        return true;
      }
      else if (PlayerOne == "rock" && PlayerTwo == "scissors" ||PlayerOne == "paper" && PlayerTwo == "rock" || PlayerOne == "scissors" && PlayerTwo == "paper")
      {
        Console.WriteLine("PlayerOne Wins!");
        return true;
      }
      else
      {
        Console.WriteLine("PlayerTwo Wins!");
        return false;
      }
    }



  //   private string _description;
  //   private static List<Item> _instances = new List<Item>{};
  //
  //   public Item (string description)
  //   {
  //     _description = description;
  //   }
  //   public string GetDescription()
  //   {
  //     return _description;
  //   }
  //   public void SetDescription(string newDescription)
  //   {
  //     _description = newDescription;
  //   }
  //   public static List<Item> GetAll()
  //   {
  //     return _instances;
  //   }
  //   public void Save()
  //   {
  //     _instances.Add(this);
  //   }
  //       public static void ClearAll()
  //   {
  //     _instances.Clear();
  //   }
  }
}
