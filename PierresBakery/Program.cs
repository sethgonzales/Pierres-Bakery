//USING DIRECTIVES HERE
using PierresBakery.Models;
using System;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Pierre's Bakery!");
      Console.WriteLine("We offer a beautiful selection of bread and pastries.");
      Console.WriteLine("How many loaves of bread would you like (enter a number)?");
      string breadOrderString = Console.ReadLine();
      Console.WriteLine("How many pastries would you like? (enter a number)");
      string pastryOrderString = Console.ReadLine();

      bool breadOrderValue = int.TryParse(breadOrderString);
      bool pastryOrderValue = int.TryParse(pastryOrderString);

      if (breadOrderValue && pastryOrderValue)
      {
        int breadOrder = int.Parse(breadOrderString);
        int pastryOrder = int.Parse(breadOrderString);
        TotalCost newOrder = new TotalCost(breadOrder, pastryOrder);
        int totalCost = newOrder.GetTotalCost();
        Console.WriteLine("=================================================");
        Console.WriteLine($"Your order comes out to be ${totalCost}.");
        Console.WriteLine("=================================================");
      }
      else
      {
        Console.WriteLine("Please enter a numerical value such as '1' rather than 'one' or '1.0' for each of your orders");
      }

    }

  }
}