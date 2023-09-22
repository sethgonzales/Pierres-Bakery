//USING DIRECTIVES HERE
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

      if (continueOn.ToLower() == "yes")
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

        if (breadOrderValue && pastryOrderValue)
        {
          TotalCost newOrder = new TotalCost(breadOrder, pastryOrder);
          int totalCost = newOrder.GetTotalCost();
          Console.WriteLine("==================================================================");
          Console.WriteLine($"Thank you {customerName}!");
          Console.WriteLine($"Your order comes out to be ${totalCost}.");
          Console.WriteLine($"Enjoy!");
          Console.WriteLine("==================================================================");
        }
        else
        {
          Console.BackgroundColor = ConsoleColor.DarkMagenta;
          Console.WriteLine("==================================================================");
          Console.WriteLine("Please enter a numerical values such as '1'");
          Console.WriteLine("rather than 'one' or '1.0' for each of your orders");
          Console.WriteLine("==================================================================");
          Console.WriteLine("Type 'yes' to continue, or any other key to exit");
          Console.ForegroundColor = ConsoleColor.White;
          string restart = Console.ReadLine();

          if (restart.ToLower() == "yes")
          {
            Main();
          }
          else
          {
            Console.WriteLine("Thanks for stopping by, we hope to see you again!");
          }
        }
      }
      else
      {
        Console.WriteLine("Thanks for stopping by, we hope to see you again!");
      }
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.Black;

    }
  }
}