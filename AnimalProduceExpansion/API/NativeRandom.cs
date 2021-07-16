using System;

namespace AnimalProduceExpansion.API
{
  public class NativeRandom : IRandomApi
  {
    public Random GetNewRandom() => new Random();
    public Random GetNewRandom(int seed) => new Random(seed);

    public Random GetNewRandom(long seed) => new Random();
    public Random GetNamedRandom(string name) => new Random();
    public Random GetNamedRandom(string name, long seed) => new Random();
  }
}