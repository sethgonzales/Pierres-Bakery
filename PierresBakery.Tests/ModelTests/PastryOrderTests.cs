using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryOrderConstructor_CreateInstanceOfBreadOrder_BreadOrder()
    {
      //arrange and act
      PastryOrder newPastryOrder = new PastryOrder(1);
      //assert
      Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
    }
    [TestMethod]
    public void GetPastryCost_ReturnPriceOfSinglePastry_Int()
    {
      //arrange 
      int expectedCost = 2;
      PastryOrder newPastryOrder = new PastryOrder(1);
      //act
      int theoreticalCost = newPastryOrder.GetPastryCost();
      //assert
      Assert.AreEqual(expectedCost, theoreticalCost);
    }
  //   [TestMethod]
  //   public void GetBreadCost_ReturnPriceOfTwoBreadLoaves_Int()
  //   {
  //     //arrange 
  //     int expectedCost = 10;
  //     BreadOrder newBreadOrder = new BreadOrder(2);
  //     //act
  //     int theoreticalCost = newBreadOrder.GetBreadCost();
  //     //assert
  //     Assert.AreEqual(expectedCost, theoreticalCost);
  //   }
  //     [TestMethod]
  //   public void GetBreadCost_ReturnPriceOfThreeBreadLoaves_Int()
  //   {
  //     //arrange 
  //     int expectedCost = 10;
  //     BreadOrder newBreadOrder = new BreadOrder(3);
  //     //act
  //     int theoreticalCost = newBreadOrder.GetBreadCost();
  //     //assert
  //     Assert.AreEqual(expectedCost, theoreticalCost);
  //   }
  }
}
