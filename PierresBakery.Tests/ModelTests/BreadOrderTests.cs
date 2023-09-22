using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadOrderConstructor_CreateInstanceOfBreadOrder_BreadOrder()
    {
      //arrange and act
      BreadOrder newBreadOrder = new BreadOrder(1);
      //assert
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
    }
    [TestMethod]
    public void GetBreadCost_ReturnPriceOfSingleBreadLoaf_Int()
    {
      //arrange 
      int expectedCost = 5;
      BreadOrder newBreadOrder = new BreadOrder(1);
      //act
      int actuallCost = newBreadOrder.GetBreadCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
    [TestMethod]
    public void GetBreadCost_ReturnPriceOfTwoBreadLoaves_Int()
    {
      //arrange 
      int expectedCost = 10;
      BreadOrder newBreadOrder = new BreadOrder(2);
      //act
      int actuallCost = newBreadOrder.GetBreadCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
      [TestMethod] //additional test to see if cost is the same as two loaves of bread
    public void GetBreadCost_ReturnPriceOfThreeBreadLoaves_Int() 
    {
      //arrange 
      int expectedCost = 10;
      BreadOrder newBreadOrder = new BreadOrder(3);
      //act
      int actuallCost = newBreadOrder.GetBreadCost();
      //assert
      Assert.AreEqual(expectedCost, actuallCost);
    }
  }
}