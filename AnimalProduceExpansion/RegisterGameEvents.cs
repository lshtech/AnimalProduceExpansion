using System.Collections.Generic;
using AnimalProduceExpansion.API;
using StardewModdingAPI;
using StardewModdingAPI.Events;
// ReSharper disable StringLiteralTypo

namespace AnimalProduceExpansion
{
  internal class RegisterGameEvents : Utility
  {
    private static IModHelper _helper;

    public RegisterGameEvents(IModHelper helper)
    {
      _helper = helper;
      RegisteredApis = new Dictionary<string, object>();
      helper.Events.GameLoop.GameLaunched += GameLoop_GameLaunched;
    }
    

    private void GameLoop_GameLaunched(object sender, GameLaunchedEventArgs e)
    {
      LogDebug("Registering APIs");

      _helper.ModRegistry.GetApi<IJsonAssetsApi>("spacechase0.JsonAssets").RegisterApi();
      if (_helper.ModRegistry.IsLoaded("pepoluan.EvenBetterRNG"))
        _helper.ModRegistry.GetApi<IRandomApi>("pepoluan.EvenBetterRNG").RegisterApi();
      else
        new NativeRandom().RegisterApi<IRandomApi>();
    }

    internal static bool IsModLoaded(string modId) => _helper.ModRegistry.IsLoaded(modId);

  }
}