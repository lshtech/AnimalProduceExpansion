using AnimalProduceExpansion.Data;
using AnimalProduceExpansion.Patches;
using StardewModdingAPI;

namespace AnimalProduceExpansion
{
  // ReSharper disable once UnusedMember.Global
  public class ModEntry : Mod
  {
    public override void Entry(IModHelper helper)
    {
      Utility.SetLogger(Monitor);
      Utility.SetConfigManager(new ConfigManager.ConfigManager(helper.ReadConfig<Config>()));
      HarmonyPatcher.RegisterPatches();
      _ = new RegisterGameEvents(helper);
    }
  }
}