using System;
using System.Reflection;
using Harmony;

namespace AnimalProduceExpansion.Patches
{
  internal class HarmonyPatcher
  {
    internal static void RegisterPatches()
    {
      try
      {
        var harmonyInstance = HarmonyInstance.Create("elbe.AnimalShopConditions");
        harmonyInstance.PatchAll(Assembly.GetExecutingAssembly());
      }
      catch (Exception ex)
      {
        Utility.LogError(ex.Message, ex);
      }
    }
  }
}