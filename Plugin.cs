using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using BepInEx.Configuration;

namespace ScaleableShip
{

    [BepInPlugin("ScaleableShip", "\u200bScaleableShip", "0.0.6")]
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
            if (!ConfigManager.activateMode.Value)
            {
                return;
            }
            else
            {
                if (ConfigManager.newMode.Value)
                {
                    if (StartOfRound.Instance != null && StartOfRound.Instance.elevatorTransform != null)
                    {
                        StartOfRound.Instance.elevatorTransform.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                    }
                }
                else
                {
                    GameObject shipinside = GameObject.Find("ShipInside");
                    if (shipinside != null)
                    {
                        shipinside.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                        shipinside.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    }
                    GameObject shipinside001 = GameObject.Find("ShipInside.001");
                    if (shipinside001 != null)
                    {
                        shipinside001.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                        shipinside001.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    }
                    GameObject shiphull = GameObject.Find("ShipHull");
                    if (shiphull != null)
                    {
                        shiphull.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                        shiphull.transform.localPosition = new Vector3(ConfigManager.shipPositionX.Value, ConfigManager.shipPositionY.Value, ConfigManager.shipPositionZ.Value);
                    }
                    GameObject catwalkship = GameObject.Find("CatwalkShip");
                    if (catwalkship != null)
                    {
                        catwalkship.transform.localScale = new Vector3(ConfigManager.catwalkshipScaleX.Value, ConfigManager.catwalkshipScaleY.Value, ConfigManager.catwalkshipScaleZ.Value);
                        catwalkship.transform.localPosition = new Vector3(ConfigManager.catwalkshipPositionX.Value, ConfigManager.catwalkshipPositionY.Value, ConfigManager.catwalkshipPositionZ.Value);
                    }

                }
                if (!ConfigManager.ignoreRailSettings.Value)
                {
                    GameObject shiprails = GameObject.Find("ShipRails");
                    if (shiprails != null)
                    {
                        shiprails.transform.localScale = new Vector3(ConfigManager.shipRailScaleX.Value, ConfigManager.shipRailScaleY.Value, ConfigManager.shipRailScaleZ.Value);
                        shiprails.transform.localPosition = new Vector3(ConfigManager.shipRailPositionX.Value, ConfigManager.shipRailPositionY.Value, ConfigManager.shipRailPositionZ.Value);
                    }
                    GameObject shiprailposts = GameObject.Find("ShipRailPosts");
                    if (shiprailposts != null)
                    {
                        shiprailposts.transform.localScale = new Vector3(ConfigManager.shipRailPostScaleX.Value, ConfigManager.shipRailPostScaleY.Value, ConfigManager.shipRailPostScaleZ.Value);
                        shiprailposts.transform.localPosition = new Vector3(ConfigManager.shipRailPostPositionX.Value, ConfigManager.shipRailPostPositionY.Value, ConfigManager.shipRailPostPositionZ.Value);
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
                //spawnroom.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //spawnroom0.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //shipsupportbeams.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //shipsupportbeams001.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //catwalkraillining.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //catwalkrailliningb.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //catwalkrailship.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //catwalkrailpost.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //pbmesh39048.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                //pbmesh84786.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
            }
        }
    }
}