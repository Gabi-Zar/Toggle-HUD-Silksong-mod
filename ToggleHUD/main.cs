using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;


[BepInPlugin("com.gabizar.togglehud", "Toggle HUD Mod", "1.0.0 ")]
public class ToggleHUD: BaseUnityPlugin
{

    private void Awake()
    {
        Logger.LogInfo("Toggle HUD mod loaded and initialized.");

        Harmony.CreateAndPatchAll(typeof(ToggleHUD), null);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            HudGlobalHide.IsHidden = !HudGlobalHide.IsHidden;
            Logger.LogInfo($"HUD hidden = {HudGlobalHide.IsHidden}");

        }
    }
}