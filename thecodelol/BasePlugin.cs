using System;
using BepInEx;
using HarmonyLib;

namespace MTM101BMDE
{

    [BepInPlugin("six.apimod.baldiplus.mainthing", "Basic API", "1.0.0.0")]
    public class BasePlugin : BaseUnityPlugin
    {
        public static BasePlugin Instance;

        void Awake()
        {
            Harmony harmony = new Harmony("six.apimod.baldiplus.mainthing");
            harmony.PatchAll();
            Instance = this;
            //harmony.PatchAllConditionals();
        }
    }
}