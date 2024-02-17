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

        public static ConfigEntry<bool> activateMode { get; private set; }
        public static ConfigEntry<float> shipScaleX { get; private set; }
        public static ConfigEntry<float> shipScaleY { get; private set; }
        public static ConfigEntry<float> shipScaleZ { get; private set; }
        public static ConfigEntry<float> catwalkshipScaleX { get; private set; }
        public static ConfigEntry<float> catwalkshipScaleY { get; private set; }
        public static ConfigEntry<float> catwalkshipScaleZ { get; private set; }
        public static ConfigEntry<float> catwalkshipPositionX { get; private set; }
        public static ConfigEntry<float> catwalkshipPositionY { get; private set; }
        public static ConfigEntry<float> catwalkshipPositionZ { get; private set; }
        //public static ConfigEntry<float> tvPositionY { get; private set; }
        public static ConfigFile configFile { get; private set; }

        private ConfigManager(ConfigFile cfg)
        {
            configFile = cfg;
            activateMode = cfg.Bind("Options", "Enabled", true, "Enables the mod.");
            shipScaleX = cfg.Bind("Options", "Ship Scale X", 2f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipScaleY = cfg.Bind("Options", "Ship Scale Y", 2f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipScaleZ = cfg.Bind("Options", "Ship Scale Z", 1f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipScaleX = cfg.Bind("Options", "Catwalk Scale X", 1.9f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipScaleY = cfg.Bind("Options", "Catwalk Scale Y", 2f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipScaleZ = cfg.Bind("Options", "Catwalk Scale Z", 0.2f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipPositionX = cfg.Bind("Options", "Catwalk Position X", -15f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipPositionY = cfg.Bind("Options", "Catwalk Position Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipPositionZ = cfg.Bind("Options", "Catwalk Position Z", -6f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
        }
    }
}