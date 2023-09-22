using System;

namespace PierresBakery.Models
{
  public class BreadOrder
  {
    public int Loaves { get; set; }

    public BreadOrder(int order)
    {
      Loaves = order;
    }

  }

}