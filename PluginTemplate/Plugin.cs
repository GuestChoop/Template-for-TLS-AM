using BepInEx;
using BepInEx.Unity.IL2CPP;

namespace PluginTemplate
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class Plugin : BasePlugin
    {
        public const string PLUGIN_GUID = "ID your mod (unique)";
        public const string PLUGIN_NAME = "Name your mod";
        public const string PLUGIN_VERSION = "1.0.0";
        public static Plugin Instance;
        public override void Load()
        {
            Instance = this;
            /* ClassInjector.RegisterTypeInIl2Cpp<YourSomeClass>();    => Optionally, if you want to write another class, you must inject it into the domain
            var newObj = new GameObject("Mod Menu")
            {
                hideFlags = HideFlags.HideAndDontSave
            };
            newObj.AddComponent<YourSomeClass>();
            Object.DontDestroyOnLoad(newObj); */
            Log.LogInfo($"Plugin {PLUGIN_NAME} is loaded!");
            // Write some your code here //
        }
    }
}