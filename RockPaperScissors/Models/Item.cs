using System;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList.Models
{
  public class Hand
  {
    
    // public string Choice { get; set }

    public Hand(string userInput1)
    {
      
    }

    // public string GetUserInput()
    // {
    //   return _userInput;
    // }

    public bool IsWord(string userInput1)
    {
      if (String.IsNullOrWhiteSpace(userInput1)) 
      {
        return true;
      } 
      else 
      {
        return false;
      }
    }

    public bool Decider(string userInput1)
    {
      if (userInput1 == "Rock")
      {
        return true;
      }
      else if (userInput1 == "Paper")
      {
        return true;
      }
       else if (userInput1 == "Scissors")
      {
        return true;
      }
      else 
      {
        return false;
      }
    }



    // public string Description { get; set; }
    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    // private static List<Item> _instances = new List<Item> {};
    // // constructor
    // public Item(string description)
    // {
    //   Description = description;
    //   _instances.Add(this);
    // }
  }
}

