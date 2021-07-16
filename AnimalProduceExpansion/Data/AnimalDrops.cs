using System.Collections.Generic;

namespace AnimalProduceExpansion.Data
{
  public class AnimalDrops
  {
    public string Animal { get; set; }
    public IList<Drop> Drops { get; set; }
    public double ChanceForExtraDrop { get; set; }
    public IList<Drop> ExtraDrops { get; set; }
    internal bool Cached { get; set; }
  }
}