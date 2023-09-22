namespace PierresBakery.Models
{
  public class PastryOrder
  {
    public int Pastries { get; }

    public PastryOrder(int order)
    {
      Pastries = order;
    }
    
    public int GetPastryCost()
    {
      int pastryCost = 2;
      int freePastries = Pastries / 4;
      int pastryCalc = (Pastries - freePastries) * pastryCost;
      return pastryCalc;
    }
  }
}