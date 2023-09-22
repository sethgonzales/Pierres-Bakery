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
  }
}