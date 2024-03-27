using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using BepInEx.Configuration;
using System;

namespace ScaleableShip
{

    [BepInPlugin("ScaleableShip", "\u200bScaleableShip", "0.0.7")]
    public class ScaleableShip : BaseUnityPlugin
    {
        public enum ConfigType
        {
            None,
            ConvertibleNoRails,
            Convertible,
            BigCentered,
            Defaults
        }
        public static void ApplyPresetConfiguration(ConfigType preset)
        {
            switch (preset)
            {
                case ConfigType.None:
                    // Apply default configuration
                    break;
                case ConfigType.ConvertibleNoRails:
                    activateMode.Value = true;
                    ignoreRailSettings.Value = false;
                    newMode.Value = false;
                    shipScaleX.Value = 1f;
                    shipScaleY.Value = 0.01f;
                    shipScaleZ.Value = 1f;
                    shipPositionX.Value = -5.25f;
                    shipPositionY.Value = 0f;
                    shipPositionZ.Value = 0f;
                    catwalkshipScaleX.Value = 1f;
                    catwalkshipScaleY.Value = 0.01f;
                    catwalkshipScaleZ.Value = 1f;
                    catwalkshipPositionX.Value = -5.5f;
                    catwalkshipPositionY.Value = 0f;
                    catwalkshipPositionZ.Value = -8.5f;
                    shipRailScaleX.Value = 0f;
                    shipRailScaleY.Value = 0f;
                    shipRailScaleZ.Value = 0f;
                    shipRailPostScaleX.Value = 0f;
                    shipRailPostScaleY.Value = 0f;
                    shipRailPostScaleZ.Value = 0f;
                    break;
                case ConfigType.Convertible:
                    activateMode.Value = true;
                    ignoreRailSettings.Value = true;
                    newMode.Value = false;
                    shipScaleX.Value = 1f;
                    shipScaleY.Value = 0.01f;
                    shipScaleZ.Value = 1f;
                    shipPositionX.Value = -5.25f;
                    shipPositionY.Value = 0f;
                    shipPositionZ.Value = 0f;
                    catwalkshipScaleX.Value = 1f;
                    catwalkshipScaleY.Value = 0.01f;
                    catwalkshipScaleZ.Value = 1f;
                    catwalkshipPositionX.Value = -5.5f;
                    catwalkshipPositionY.Value = 0f;
                    catwalkshipPositionZ.Value = -8.5f;
                    break;
                case ConfigType.BigCentered:
                    activateMode.Value = true;
                    ignoreRailSettings.Value = false;
                    newMode.Value = false;
                    shipScaleX.Value = 6f;
                    shipScaleY.Value = 2f;
                    shipScaleZ.Value = 3f;
                    shipPositionX.Value = 2f;
                    shipPositionY.Value = 2f;
                    shipPositionZ.Value = 12.5f;
                    catwalkshipScaleX.Value = 5f;
                    catwalkshipScaleY.Value = 0.9f;
                    catwalkshipScaleZ.Value = 3f;
                    catwalkshipPositionX.Value = 0f;
                    catwalkshipPositionY.Value = -1.48f;
                    catwalkshipPositionZ.Value = -13f;
                    shipRailScaleX.Value = 0f;
                    shipRailScaleY.Value = 0f;
                    shipRailScaleZ.Value = 0f;
                    shipRailPostScaleX.Value = 0f;
                    shipRailPostScaleY.Value = 0f;
                    shipRailPostScaleZ.Value = 0f;
                    break;
                case ConfigType.Defaults:
                    activateMode.Value = true;
                    ignoreRailSettings.Value = true;
                    newMode.Value = false;
                    shipScaleX.Value = 1f;
                    shipScaleY.Value = 1f;
                    shipScaleZ.Value = 1f;
                    shipPositionX.Value = -5.25f;
                    shipPositionY.Value = 1f;
                    shipPositionZ.Value = 0f;
                    catwalkshipScaleX.Value = 1f;
                    catwalkshipScaleY.Value = 0.01f;
                    catwalkshipScaleZ.Value = 1f;
                    catwalkshipPositionX.Value = -5.5f;
                    catwalkshipPositionY.Value = 0f;
                    catwalkshipPositionZ.Value = -8.5f;
                    shipRailScaleX.Value = 0f;
                    shipRailScaleY.Value = 0f;
                    shipRailScaleZ.Value = 0f;
                    shipRailPostScaleX.Value = 0f;
                    shipRailPostScaleY.Value = 0f;
                    shipRailPostScaleZ.Value = 0f;
                    break;
                default:

                    break;
            }
        }

        public static ConfigEntry<bool> activateMode { get; set; }
        public static ConfigEntry<bool> newMode { get; set; }
        public static ConfigEntry<bool> ignoreRailSettings { get; set; }
        public static ConfigEntry<ConfigType> currentPreset { get; set; }
        public static ConfigEntry<float> shipScaleX { get; set; }
        public static ConfigEntry<float> shipScaleY { get; set; }
        public static ConfigEntry<float> shipScaleZ { get; set; }
        public static ConfigEntry<float> shipPositionX { get; set; }
        public static ConfigEntry<float> shipPositionY { get; set; }
        public static ConfigEntry<float> shipPositionZ { get; set; }
        public static ConfigEntry<float> shipRailScaleX { get; set; }
        public static ConfigEntry<float> shipRailScaleY { get; set; }
        public static ConfigEntry<float> shipRailScaleZ { get; set; }
        public static ConfigEntry<float> shipRailPositionX { get; set; }
        public static ConfigEntry<float> shipRailPositionY { get; set; }
        public static ConfigEntry<float> shipRailPositionZ { get; set; }
        public static ConfigEntry<float> shipRailPostScaleX { get; set; }
        public static ConfigEntry<float> shipRailPostScaleY { get; set; }
        public static ConfigEntry<float> shipRailPostScaleZ { get; set; }
        public static ConfigEntry<float> shipRailPostPositionX { get; set; }
        public static ConfigEntry<float> shipRailPostPositionY { get; set; }
        public static ConfigEntry<float> shipRailPostPositionZ { get; set; }
        public static ConfigEntry<float> catwalkshipScaleX { get; set; }
        public static ConfigEntry<float> catwalkshipScaleY { get; set; }
        public static ConfigEntry<float> catwalkshipScaleZ { get; set; }
        public static ConfigEntry<float> catwalkshipPositionX { get; set; }
        public static ConfigEntry<float> catwalkshipPositionY { get; set; }
        public static ConfigEntry<float> catwalkshipPositionZ { get; set; }
        
        private ConfigType lastPreset;
        
        static new GameObject? gameObject;
        void Awake()
        {
            activateMode = Config.Bind("Options", "Enabled", true, "Enables the mod.");
            currentPreset = Config.Bind("Options", "Current Preset", ConfigType.None, "Preset configurations");
            ignoreRailSettings = Config.Bind("Options", "Ignore Rail Settings", true, "If this is checked keep the railing the way it is.");
            newMode = Config.Bind("Options", "New Mode", false, "Enables the new mode which scales everything, only uses Ship Scale values.");
            shipScaleX = Config.Bind("Options", "Ship Scale X", 1f, "X Coordinates\n Left/Right");
            shipScaleY = Config.Bind("Options", "Ship Scale Y", 1f, "Y Coordinates\n Up/Down");
            shipScaleZ = Config.Bind("Options", "Ship Scale Z", 1f, "Z Coordinates\n Front/Back");
            shipPositionX = Config.Bind("Options", "Ship Position X", -5.25f, "X Coordinates\n Left/Right");
            shipPositionY = Config.Bind("Options", "Ship Position Y", 1f, "Y Coordinates\n Up/Down");
            shipPositionZ = Config.Bind("Options", "Ship Position Z", 0f, "Z Coordinates\n Front/Back");
            catwalkshipScaleX = Config.Bind("Options", "Catwalk Scale X", 1f, "X Coordinates\n Left/Right");
            catwalkshipScaleY = Config.Bind("Options", "Catwalk Scale Y", 0.01f, "Y Coordinates\n Up/Down");
            catwalkshipScaleZ = Config.Bind("Options", "Catwalk Scale Z", 1f, "Z Coordinates\n Front/Back");
            catwalkshipPositionX = Config.Bind("Options", "Catwalk Position X", -5.5f, "X Coordinates\n Left/Right");
            catwalkshipPositionY = Config.Bind("Options", "Catwalk Position Y", 0f, "Y Coordinates\n Up/Down");
            catwalkshipPositionZ = Config.Bind("Options", "Catwalk Position Z", -8.5f, "Z Coordinates\n Front/Back");
            shipRailScaleX = Config.Bind("Options", "Ship Rail Scale X", 0f, "X Coordinates\n Left/Right");
            shipRailScaleY = Config.Bind("Options", "Ship Rail Scale Y", 0f, "Y Coordinates\n Up/Down");
            shipRailScaleZ = Config.Bind("Options", "Ship Rail Scale Z", 0f, "Z Coordinates\n Front/Back");
            shipRailPositionX = Config.Bind("Options", "Ship Rail Position X", 0f, "X Coordinates\n Left/Right");
            shipRailPositionY = Config.Bind("Options", "Ship Rail Position Y", 0f, "Y Coordinates\n Up/Down");
            shipRailPositionZ = Config.Bind("Options", "Ship Rail Position Z", 0f, "Z Coordinates\n Front/Back");
            shipRailPostScaleX = Config.Bind("Options", "Ship Rail Post Scale X", 0f, "X Coordinates\n Left/Right");
            shipRailPostScaleY = Config.Bind("Options", "Ship Rail Post Scale Y", 0f, "Y Coordinates\n Up/Down");
            shipRailPostScaleZ = Config.Bind("Options", "Ship Rail Post Scale Z", 0f, "Z Coordinates\n Front/Back");
            shipRailPostPositionX = Config.Bind("Options", "Ship Rail Post Position X", 0f, "X Coordinates\n Left/Right");
            shipRailPostPositionY = Config.Bind("Options", "Ship Rail Post Position Y", 0f, "Y Coordinates\n Up/Down");
            shipRailPostPositionZ = Config.Bind("Options", "Ship Rail Post Position Z", 0f, "Z Coordinates\n Front/Back");
            Logger.LogInfo($"Plugin {"ScaleableShip"} is loaded!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
            lastPreset = currentPreset.Value;
        }

        private void Update()
        {
            if (!activateMode.Value)
            {
                return;
            }
            else
            {
                if (newMode.Value)
                {
                    if (StartOfRound.Instance != null && StartOfRound.Instance.elevatorTransform != null)
                    {
                        StartOfRound.Instance.elevatorTransform.transform.localScale = new Vector3(shipScaleZ.Value, shipScaleX.Value, shipScaleY.Value);
                    }
                }
                else
                {
                    GameObject shipinside = GameObject.Find("ShipInside");
                    if (shipinside != null)
                    {
                        shipinside.transform.localScale = new Vector3(shipScaleZ.Value, shipScaleX.Value, shipScaleY.Value);
                        shipinside.transform.localPosition = new Vector3(shipPositionZ.Value, shipPositionY.Value, shipPositionX.Value);
                    }
                    GameObject shipinside001 = GameObject.Find("ShipInside.001");
                    if (shipinside001 != null)
                    {
                        shipinside001.transform.localScale = new Vector3(shipScaleZ.Value, shipScaleX.Value, shipScaleY.Value);
                        shipinside001.transform.localPosition = new Vector3(shipPositionZ.Value, shipPositionY.Value, shipPositionX.Value);
                    }
                    GameObject shiphull = GameObject.Find("ShipHull");
                    if (shiphull != null)
                    {
                        shiphull.transform.localScale = new Vector3(shipScaleZ.Value, shipScaleX.Value, shipScaleY.Value);
                        shiphull.transform.localPosition = new Vector3(shipPositionZ.Value, shipPositionY.Value, shipPositionX.Value);
                    }
                    GameObject catwalkship = GameObject.Find("CatwalkShip");
                    if (catwalkship != null)
                    {
                        catwalkship.transform.localScale = new Vector3(catwalkshipScaleZ.Value, catwalkshipScaleX.Value, catwalkshipScaleY.Value);
                        catwalkship.transform.localPosition = new Vector3(catwalkshipPositionZ.Value, catwalkshipPositionY.Value, catwalkshipPositionX.Value);
                    }

                }
                if (!ignoreRailSettings.Value)
                {
                    GameObject shiprails = GameObject.Find("ShipRails");
                    if (shiprails != null)
                    {
                        shiprails.transform.localScale = new Vector3(shipRailScaleZ.Value, shipRailScaleY.Value, shipRailScaleX.Value);
                        shiprails.transform.localPosition = new Vector3(shipRailPositionZ.Value, shipRailPositionY.Value, shipRailPositionX.Value);
                    }
                    GameObject shiprailposts = GameObject.Find("ShipRailPosts");
                    if (shiprailposts != null)
                    {
                        shiprailposts.transform.localScale = new Vector3(shipRailPostScaleZ.Value, shipRailPostScaleX.Value, shipRailPostScaleY.Value);
                        shiprailposts.transform.localPosition = new Vector3(shipRailPostPositionZ.Value, shipRailPostPositionY.Value, shipRailPostPositionX.Value);
                    }
                }
                //GameObject cozylights = GameObject.Find("CozyLights");
                //GameObject cozylightslod1 = GameObject.Find("CozyLightsLOD1");
                //GameObject shipsupportbeams = GameObject.Find("ShipSupportBeams");
                //GameObject spawnroom = GameObject.Find("SpawnRoom");
                //GameObject spawnroom0 = GameObject.Find("SpawnRoom_0");
                //GameObject shipsupportbeams001 = GameObject.Find("ShipSupportBeams.001");
                //GameObject catwalkraillining = GameObject.Find("CatwalkRailLining");
                //GameObject catwalkrailliningb = GameObject.Find("CatwalkRailLiningB");
                //GameObject catwalkrailship = GameObject.Find("CatwalkRailShip");
                //GameObject catwalkrailpost = GameObject.Find("CatwalkRailPost");
                //GameObject pbmesh39048 = GameObject.Find("pb_Mesh39048");
                //GameObject pbmesh84786 = GameObject.Find("pb_Mesh84786");
                //spawnroom.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //spawnroom0.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //shipsupportbeams.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //shipsupportbeams001.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //catwalkraillining.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //catwalkrailliningb.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //catwalkrailship.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //catwalkrailpost.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //pbmesh39048.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                //pbmesh84786.transform.localScale = new Vector3(shipScaleX.Value, shipScaleY.Value, shipScaleZ.Value);
                if (currentPreset.Value != lastPreset)
                {
                    lastPreset = currentPreset.Value;
                    ApplyPresetConfiguration(currentPreset.Value);
                }
            }
        }
    }
}