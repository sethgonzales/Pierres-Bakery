//USING DIRECTIVES HERE
using PierresBakery.Models;
using System;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.DarkYellow;
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*");
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Console.WriteLine("We offer a beautiful selection of bread and pastries.");
      Console.WriteLine("");
      Console.WriteLine("Menu:");
      Console.WriteLine("---------------------");
      Console.WriteLine("|Bread     |     $5 |");
      Console.WriteLine("|Pastry    |     $2 |");
      Console.WriteLine("---------------------");
      Console.WriteLine("");
      Console.WriteLine("Deal of the day!");
      Console.WriteLine("Buy two, get one FREE on bread");
      Console.WriteLine("Buy three, get one FREE on pastries");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~**~*~*~*");
      Console.WriteLine("Type 'yes' to continue, or any other key to exit");
      string continueOn = Console.ReadLine();

      if (continueOn.ToLower() == "yes")
      {
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("How many loaves of bread would you like? (enter a number)");
        string breadOrderString = Console.ReadLine();
        Console.WriteLine("How many pastries would you like? (enter a number)");
        string pastryOrderString = Console.ReadLine();

        int breadOrder;
        int pastryOrder;

        bool breadOrderValue = int.TryParse(breadOrderString, out breadOrder);
        bool pastryOrderValue = int.TryParse(pastryOrderString, out pastryOrder);

        if (breadOrderValue && pastryOrderValue)
        {
          TotalCost newOrder = new TotalCost(breadOrder, pastryOrder);
          int totalCost = newOrder.GetTotalCost();
          Console.WriteLine("==================================================");
          Console.WriteLine($"Your order comes out to be ${totalCost}.");
          Console.WriteLine("==================================================");
        }
        else
        {
          Console.WriteLine("==================================================");
          Console.WriteLine("Please enter a numerical values such as '1'");
          Console.WriteLine("rather than 'one' or '1.0' for each of your orders");
          Console.WriteLine("==================================================");
          Console.WriteLine("Type 'yes' to continue, or any other key to exit");
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
    }
  }
}