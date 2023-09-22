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
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("~~~~~~~~~~~~~~ Crazy deal alert!!! ~~~~~~~~~~~~~~");
      Console.WriteLine("~~~ Buy two loaves of bread and get one free! ~~~");
      Console.WriteLine("~~~~~ Buy three pastries and get one free! ~~~~~");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("How many loaves of bread would you like (enter a number)?");
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

      }
    }

  }
}