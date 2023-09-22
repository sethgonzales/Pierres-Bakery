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
      int theoreticalCost = newBreadOrder.GetBreadCost();
      //assert
      Assert.AreEqual(expectedCost, theoreticalCost);
    }
    // [TestMethod]
    // public void GetBreadCost_ReturnPriceOfTwoBreadLoaves_Int()
    // {
    //   //arrange 
    //   int expectedCost = 10;
    //   BreadOrder newBreadOrder = new BreadOrder(2);
    //   //act
    //   int theoreticalCost = newBreadOrder.GetBreadCost();
    //   //assert
    //   Assert.AreEqual(expectedCost, theoreticalCost);
    }
  }

}

// ! NOTE:
// NAME CONVENTION FOR TESTS:
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//    Arrange
//    Act
//    Assert
// }