using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using BepInEx.Configuration;

namespace ScaleableShip
{
    [BepInPlugin("ScaleableShip", "ScaleableShip", "0.0.1")]
    [HarmonyPatch]
    public class ScaleableShip : BaseUnityPlugin
    {
        static new GameObject? gameObject;
        void Awake()
        {
            ConfigManager.Init(Config);
            Logger.LogInfo($"Plugin {"ScaleableTelevision"} is loaded!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    

        private void Update()
        {
            {
                GameObject val = GameObject.Find("ShipInside");
                val.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
            }
        }
    }
}
