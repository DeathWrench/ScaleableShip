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
        public static ConfigEntry<bool> newMode { get; private set; }
        public static ConfigEntry<float> shipScaleX { get; private set; }
        public static ConfigEntry<float> shipScaleY { get; private set; }
        public static ConfigEntry<float> shipScaleZ { get; private set; }
        public static ConfigEntry<float> shipPositionX { get; private set; }
        public static ConfigEntry<float> shipPositionY { get; private set; }
        public static ConfigEntry<float> shipPositionZ { get; private set; }
        public static ConfigEntry<float> shipRailScaleX { get; private set; }
        public static ConfigEntry<float> shipRailScaleY { get; private set; }
        public static ConfigEntry<float> shipRailScaleZ { get; private set; }
        public static ConfigEntry<float> shipRailPositionX { get; private set; }
        public static ConfigEntry<float> shipRailPositionY { get; private set; }
        public static ConfigEntry<float> shipRailPositionZ { get; private set; }
        public static ConfigEntry<float> shipRailRotationX { get; private set; }
        public static ConfigEntry<float> shipRailRotationY { get; private set; }
        public static ConfigEntry<float> shipRailRotationZ { get; private set; }
        public static ConfigEntry<float> shipRailPostScaleX { get; private set; }
        public static ConfigEntry<float> shipRailPostScaleY { get; private set; }
        public static ConfigEntry<float> shipRailPostScaleZ { get; private set; }
        public static ConfigEntry<float> shipRailPostPositionX { get; private set; }
        public static ConfigEntry<float> shipRailPostPositionY { get; private set; }
        public static ConfigEntry<float> shipRailPostPositionZ { get; private set; }
        public static ConfigEntry<float> shipRailPostRotationX { get; private set; }
        public static ConfigEntry<float> shipRailPostRotationY { get; private set; }
        public static ConfigEntry<float> shipRailPostRotationZ { get; private set; }
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
            newMode = cfg.Bind("Options", "New Mode", true, "Enables the new mode which scales everything, only uses Ship Scale values.");
            shipScaleX = cfg.Bind("Options", "Ship Scale X", 2f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipScaleY = cfg.Bind("Options", "Ship Scale Y", 2f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipScaleZ = cfg.Bind("Options", "Ship Scale Z", 1f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipPositionX = cfg.Bind("Options", "Ship Position X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipPositionY = cfg.Bind("Options", "Ship Position Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipPositionZ = cfg.Bind("Options", "Ship Position Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipRailScaleX = cfg.Bind("Options", "Ship Rail Scale X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipRailScaleY = cfg.Bind("Options", "Ship Rail Scale Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipRailScaleZ = cfg.Bind("Options", "Ship Rail Scale Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipRailPositionX = cfg.Bind("Options", "Ship Rail Position X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipRailPositionY = cfg.Bind("Options", "Ship Rail Position Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipRailPositionZ = cfg.Bind("Options", "Ship Rail Position Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipRailRotationX = cfg.Bind("Options", "Ship Rail Rotation X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipRailRotationY = cfg.Bind("Options", "Ship Rail Rotation Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipRailRotationZ = cfg.Bind("Options", "Ship Rail Rotation Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostScaleX = cfg.Bind("Options", "Ship Rail Post Scale X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostScaleY = cfg.Bind("Options", "Ship Rail Post Scale Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostScaleZ = cfg.Bind("Options", "Ship Rail Post Scale Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostPositionX = cfg.Bind("Options", "Ship Rail Post Position X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostPositionY = cfg.Bind("Options", "Ship Rail Post Position Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostPositionZ = cfg.Bind("Options", "Ship Rail Post Position Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostRotationX = cfg.Bind("Options", "Ship Rail Post Rotation X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostRotationY = cfg.Bind("Options", "Ship Rail Post Rotation Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipRailPostRotationZ = cfg.Bind("Options", "Ship Rail Post Rotation Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            shipPositionX = cfg.Bind("Options", "Ship Position X", 0f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            shipPositionY = cfg.Bind("Options", "Ship Position Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            shipPositionZ = cfg.Bind("Options", "Ship Position Z", 0f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipScaleX = cfg.Bind("Options", "Catwalk Scale X", 1.9f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipScaleY = cfg.Bind("Options", "Catwalk Scale Y", 2f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipScaleZ = cfg.Bind("Options", "Catwalk Scale Z", 0.2f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipPositionX = cfg.Bind("Options", "Catwalk Position X", -15f, "X Coordinates\n Left/Right");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipPositionY = cfg.Bind("Options", "Catwalk Position Y", 0f, "Y Coordinates\n Up/Down");// Make sure you put a ''f'' at the end of the number.");
            catwalkshipPositionZ = cfg.Bind("Options", "Catwalk Position Z", -6f, "Z Coordinates\n Front/Back");// Make sure you put a ''f'' at the end of the number.");
        }
    }
}