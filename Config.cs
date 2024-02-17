using BepInEx.Configuration;

namespace ScaleableShip
{
    public class ConfigManager
    {
        public static ConfigManager Instance { get; private set; }

        public static void Init(ConfigFile config)
        {
            Instance = new ConfigManager(config);
        }

        public static ConfigEntry<float> shipScaleX { get; private set; }
        public static ConfigEntry<float> shipScaleY { get; private set; }
        public static ConfigEntry<float> shipScaleZ { get; private set; }
        //public static ConfigEntry<float> tvPositionY { get; private set; }
        public static ConfigFile configFile { get; private set; }

        private ConfigManager(ConfigFile cfg)
        {
            configFile = cfg;

            shipScaleX = cfg.Bind("Options", "Ship Scale X", 2f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipScaleY = cfg.Bind("Options", "Ship Scale Y", 2f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipScaleZ = cfg.Bind("Options", "Ship Scale Z", 1f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
        }
    }
}