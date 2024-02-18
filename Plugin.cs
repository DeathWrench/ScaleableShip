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
            if (ConfigManager.activateMode.Value)
            {
                if (ConfigManager.newMode.Value)
                {
                    StartOfRound.Instance.elevatorTransform.transform.localScale = new Vector3(ConfigManager.shipScaleX.Value, ConfigManager.shipScaleY.Value, ConfigManager.shipScaleZ.Value);
                }
                else
                {
                    //GameObject cozylights = GameObject.Find("CozyLights");
                    //GameObject cozylightslod1 = GameObject.Find("CozyLightsLOD1");
                    GameObject shipinside = GameObject.Find("ShipInside");
                    GameObject shipinside001 = GameObject.Find("ShipInside.001");
                    GameObject shiphull = GameObject.Find("ShipHull");
                    GameObject shiprails = GameObject.Find("ShipRails");
                    GameObject shiprailposts = GameObject.Find("ShipRailPosts");
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
                    shiprails.transform.localScale = new Vector3(ConfigManager.shipRailScaleX.Value, ConfigManager.shipRailScaleY.Value, ConfigManager.shipRailScaleZ.Value);
                    shiprails.transform.Rotate(ConfigManager.shipRailRotationX.Value, ConfigManager.shipRailRotationY.Value, ConfigManager.shipRailRotationZ.Value, Space.World);
                    shiprails.transform.localPosition = new Vector3(ConfigManager.shipRailPositionX.Value, ConfigManager.shipRailPositionX.Value, ConfigManager.shipRailPositionX.Value);
                    shiprailposts.transform.localScale = new Vector3(ConfigManager.shipRailPostScaleX.Value, ConfigManager.shipRailPostScaleY.Value, ConfigManager.shipRailPostScaleZ.Value);
                    shiprailposts.transform.localPosition = new Vector3(ConfigManager.shipRailPostPositionX.Value, ConfigManager.shipRailPostPositionY.Value, ConfigManager.shipRailPostPositionZ.Value);
                    shiprailposts.transform.Rotate(ConfigManager.shipRailPostRotationX.Value, ConfigManager.shipRailPostRotationY.Value, ConfigManager.shipRailPostRotationZ.Value, Space.World);
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
            }
        }
        // Token: 0x06000021 RID: 33 RVA: 0x000028F0 File Offset: 0x00000AF0
        // Token: 0x06000022 RID: 34 RVA: 0x00002906 File Offset: 0x00000B06
        protected internal string __getTypeName()
        {
            return "AutoParentToShip";
        }

        // Token: 0x0400002B RID: 43
        public bool disableObject;

        // Token: 0x0400002C RID: 44
        public Vector3 positionOffset;

        // Token: 0x0400002D RID: 45
        public Vector3 rotationOffset;

        // Token: 0x0400002E RID: 46
        [HideInInspector]
        public Vector3 startingPosition;

        // Token: 0x0400002F RID: 47
        [HideInInspector]
        public Vector3 startingRotation;

        // Token: 0x04000030 RID: 48
        public bool overrideOffset;
    }
}
