using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class TotalCostTests
  {
    [TestMethod]
    public void TotalCostConstructor_CreateInstanceOfTotalOrderCostConstructor_BreadOrder()
    {
      //arrange and act
      TotalCost newOrder = new TotalCost(1, 1);
      //assert
      Assert.AreEqual(typeof(TotalCost), newOrder.GetType());
    }

    [TestMethod]
    public void GetTotalCost_ReturnPriceOfSinglePastryAndBread_Int()
    {
      //arrange 
      int expectedCost = 7;
      TotalCost newOrder = new TotalCost(1, 1);
      //act
      int actuallCost = newOrder.GetTotalCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }

    [TestMethod] //double check with multiple of each 
    public void GetTotalCost_ReturnPriceOfThreePastryAndBread_Int()
    {
      //arrange 
      int expectedCost = 16;
      TotalCost newOrder = new TotalCost(3, 3);
      //act
      int actuallCost = newOrder.GetTotalCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
  }
}