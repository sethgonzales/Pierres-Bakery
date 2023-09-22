using System;

namespace PierresBakery.Models
{
  public class TotalCost
  {
    public int TotalLoaves { get; }
    public int TotalPastries { get; }

    public TotalCost(int breadOrder, int pastriesOrder)
    {
      TotalLoaves = breadOrder;
      TotalPastries = pastriesOrder;
    }

    public int GetTotalCost()
    {
      BreadOrder newBreadOrder = new BreadOrder(TotalLoaves);
      PastryOrder newPastryOrder = new PastryOrder(TotalPastries);

      int breadCost = newBreadOrder.GetBreadCost();
      int pastryCost = newPastryOrder.GetPastryCost();
      int totalCost = breadCost + pastryCost;
      return totalCost;
    }
  }
}