using PierresBakery.Models;
using System;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      string welcomeText = "  Welcome to Pierre's Bakery!  ";
      Console.SetCursorPosition((Console.WindowWidth - welcomeText.Length) / 2, Console.CursorTop);
      Console.WriteLine(welcomeText);
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*~*~*~*");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine("We offer a beautiful selection of bread and pastries.");
      Console.WriteLine("");
      Console.WriteLine("  Menu:");
      Console.WriteLine("  ---------------------");
      Console.WriteLine("  |Bread     |     $5 |");
      Console.WriteLine("  |Pastry    |     $2 |");
      Console.WriteLine("  ---------------------");
      Console.WriteLine("");
      Console.ForegroundColor = ConsoleColor.DarkMagenta;
      Console.WriteLine("Deal of the day!");
      Console.WriteLine("Buy two, get one FREE on bread");
      Console.WriteLine("Buy three, get one FREE on pastries");
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*~*~*~*~*");
      Console.ForegroundColor = ConsoleColor.Black;
      Console.WriteLine("Type 'yes' to continue, or any other key to exit");
      Console.ForegroundColor = ConsoleColor.White;
      string continueOn = Console.ReadLine();

      if (continueOn.ToLower() == "yes") //take order if yes
      {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("How many loaves of bread would you like? (enter a number)");
        Console.ForegroundColor = ConsoleColor.White;
        string breadOrderString = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("How many pastries would you like? (enter a number)");
        Console.ForegroundColor = ConsoleColor.White;
        string pastryOrderString = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine("What is the name on the order?");
        Console.ForegroundColor = ConsoleColor.White;
        string customerName = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Black;

        int breadOrder;
        int pastryOrder;
        bool breadOrderValue = int.TryParse(breadOrderString, out breadOrder);
        bool pastryOrderValue = int.TryParse(pastryOrderString, out pastryOrder);

        if (breadOrderValue && pastryOrderValue) //finish out order if valid entry
        {
          TotalCost newOrder = new TotalCost(breadOrder, pastryOrder);
          int totalCost = newOrder.GetTotalCost();
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*~*~*~*~*");
          Console.ForegroundColor = ConsoleColor.Black;
          Console.WriteLine($"Thank you {customerName}!");
          Console.ForegroundColor = ConsoleColor.DarkMagenta;
          Console.WriteLine($"Your order comes out to be ${totalCost}.");
          Console.ForegroundColor = ConsoleColor.Black;
          Console.WriteLine($"Enjoy!");
          Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*~*~*~*~*");
          Console.ForegroundColor = ConsoleColor.Black;
        }
        else //deal with invalid order value
        {
        Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*~*~*~*~*");
          Console.ForegroundColor = ConsoleColor.DarkMagenta;          
          Console.WriteLine("Please enter numerical values such as '1',");
          Console.WriteLine("rather than 'one' or '1.0' for your orders");
        Console.ForegroundColor = ConsoleColor.DarkRed;
          Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*~*~*~*~*");
          Console.ForegroundColor = ConsoleColor.Black;          
          Console.WriteLine("Type 'yes' to continue, or any other key to exit");
          Console.ForegroundColor = ConsoleColor.White;
          string restart = Console.ReadLine();
          if (restart.ToLower() == "yes")
          {
            Main();
          }
          else //leave the store after failed order
          {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Thanks for stopping by, we hope to see you again!");
          }
        }
      }
      else //leave the store without ordering
      {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("Thanks for stopping by, we hope to see you again!");
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.Black;
    }
  }
}