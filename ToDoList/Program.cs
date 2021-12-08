using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList
{
  public class Program
  {
    public static void Main()
    {
      List<Item> newToDoList = new List<Item> { };

      Console.WriteLine("Program: Welcome to the To Do List.");
      while (true)
      {
        Console.WriteLine("Would you like to add an item to your list or view your list?(Add/View/Done)");
        string response = Console.ReadLine();
        if (response == "add" || response == "Add")
        {
          Console.WriteLine("Please enter the description for the new item.");
          string itemResponse = Console.ReadLine();
          newToDoList.Add(new Item(itemResponse));

          Console.WriteLine(itemResponse + " has been added to your list. Would you like to add an item to your list or view your list? (Add/View)");
        }
        else if (response == "view" || response == "View")
        {
          foreach (Item thing in Item.GetAll())
          {
            Console.WriteLine(thing.Description);
          }
        }
        else
        {
          Console.WriteLine("Goodbye.");
          break;
        }
      }


    }
  }
}