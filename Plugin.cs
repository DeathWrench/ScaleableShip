using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using BepInEx.Configuration;

namespace ScaleableShip
{
    [BepInPlugin("ScaleableShip", "ScaleableShip", "0.0.5")]
    [HarmonyPatch]
    public class ScaleableShip : BaseUnityPlugin
    {
        static new GameObject? gameObject;
        void Awake()
        {
            ConfigManager.Init(Config);
            Logger.LogInfo($"Plugin {"ScaleableShip"} is loaded!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
        private void Update()
        {
            if (!ConfigManager.activateMode.Value) { return; } 
            else
            {
                //if (ConfigManager.newerMode.Value)
                //{
                //    GameObject gameObject = GameObject.Find("HangarShip");
                //    string empty = string.Empty;
                //            gameObject.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //}
                if (ConfigManager.newMode.Value)
                {
                    StartOfRound.Instance.elevatorTransform.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                }
                if (!ConfigManager.newMode.Value)
                {
                    //GameObject cozylights = GameObject.Find("CozyLights");
                    //GameObject cozylightslod1 = GameObject.Find("CozyLightsLOD1");
                    GameObject shipinside = GameObject.Find("ShipInside");
                    GameObject shipinside001 = GameObject.Find("ShipInside.001");
                    GameObject shiphull = GameObject.Find("ShipHull");
                    //if (ConfigManager.shipInsideWithWindowCompat.Value) 
                    //{ 
                    //GameObject shipinsidewithwindow = GameObject.Find("ShipInsideWithWindow");
                    //shipinsidewithwindow.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //shipinsidewithwindow.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    //}
                    //GameObject shipsupportbeams = GameObject.Find("ShipSupportBeams");
                    //GameObject spawnroom = GameObject.Find("SpawnRoom");
                    //GameObject spawnroom0 = GameObject.Find("SpawnRoom_0");
                    //GameObject shipsupportbeams001 = GameObject.Find("ShipSupportBeams.001");
                    //GameObject catwalkraillining = GameObject.Find("CatwalkRailLining");
                    //GameObject catwalkrailliningb = GameObject.Find("CatwalkRailLiningB");
                    //GameObject catwalkrailship = GameObject.Find("CatwalkRailShip");
                    //GameObject catwalkrailpost = GameObject.Find("CatwalkRailPost");
                    GameObject catwalkship = GameObject.Find("CatwalkShip");
                    //GameObject pbmesh39048 = GameObject.Find("pb_Mesh39048");
                    //GameObject pbmesh84786 = GameObject.Find("pb_Mesh84786");
                    //spawnroom.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //spawnroom0.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    shipinside.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    shipinside001.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    shiphull.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    shipinside.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    shipinside001.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    shiphull.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    if (!ConfigManager.ignoreRailSettings.Value)
                    {
                        GameObject shiprails = GameObject.Find("ShipRails");
                        GameObject shiprailposts = GameObject.Find("ShipRailPosts");
                        shiprails.transform.localScale = new Vector3(ConfigManager.shipRailScaleX.Value, ConfigManager.shipRailScaleY.Value, ConfigManager.shipRailScaleZ.Value);
                        shiprails.transform.localPosition = new Vector3(ConfigManager.shipRailPositionX.Value, ConfigManager.shipRailPositionY.Value, ConfigManager.shipRailPositionZ.Value);
                        shiprailposts.transform.localScale = new Vector3(ConfigManager.shipRailPostScaleX.Value, ConfigManager.shipRailPostScaleY.Value, ConfigManager.shipRailPostScaleZ.Value);
                        shiprailposts.transform.localPosition = new Vector3(ConfigManager.shipRailPostPositionX.Value, ConfigManager.shipRailPostPositionY.Value, ConfigManager.shipRailPostPositionZ.Value);
                    }
                    //shipsupportbeams.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //shipsupportbeams001.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //catwalkraillining.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //catwalkrailliningb.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //catwalkrailship.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //catwalkrailpost.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    catwalkship.transform.localScale = new Vector3(ConfigManager.catwalkshipScaleX.Value, ConfigManager.catwalkshipScaleY.Value, ConfigManager.catwalkshipScaleZ.Value);
                    catwalkship.transform.localPosition = new Vector3(ConfigManager.catwalkshipPositionX.Value, ConfigManager.catwalkshipPositionY.Value, ConfigManager.catwalkshipPositionZ.Value);
                    //pbmesh39048.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    //pbmesh84786.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                }
            } return;
        }
    }
}
