using BepInEx;

namespace BoplTogether
{
    [BepInPlugin("us.Smach.BoplTogether", "BoplTogether", PluginInfo.PLUGIN_VERSION)]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin {PluginInfo.PLUGIN_GUID} is loaded!");
            /* Goal:
             1. Allow more players to join locally
             2. Find every instance of List<SteamConnection> connectedPlayers and turn into loops (most already are but some are hard-coded)
             3. Polish
            */
        }
    }
}