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
      
      //act
      BreadOrder newBreadOrder = new BreadOrder(1);
      //assert
      Assert.AreEqual(typeof(BreadOrder), newBreadOrder.GetType());
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