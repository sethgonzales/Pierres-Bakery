namespace PierresBakery.Models
{
  public class BreadOrder
  {
    public int Loaves { get; }

    public BreadOrder(int order)
    {
      Loaves = order;
    }

    public int GetBreadCost()
    {
      int loafCost = 5;
      int freeLoaves = Loaves / 3;
      int breadCalc = (Loaves - freeLoaves) * loafCost;
      return breadCalc;
    }
  }
}