using Harmony;
using Il2Cpp;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Chests;
using Il2CppAssets.Scripts.Inventory__Items__Pickups.Interactables;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using MelonLoader;
using System.Collections.Generic;
using UnityEngine;

[assembly: MelonInfo(typeof(MegaBonkMod.Loader), "Megabonk Mod", "1.0.0", "Maxx")]
[assembly: MelonGame("Ved", "Megabonk")]
namespace MegaBonkMod
{
    public class Loader : MelonMod
    {
        private bool masterToggle = true;
        private bool menuOpen = true;

        public override void OnUpdate()
        {
            try
            {
                if (Input.GetKeyDown(KeyCode.Insert))
                {
                    masterToggle = !masterToggle;
                }
                if (Input.GetKeyDown(KeyCode.Home))
                {
                    menuOpen = !menuOpen;
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"Keybind error: {ex.Message}");
            }
        }

        public override void OnGUI()
        {
            if (!masterToggle) return;

            try
            {
                if (!menuOpen)
                {
                    GUI.Box(new Rect(10, 10, 260, 25), "Menu Hidden [Home to show]");
                }
                else
                {
                    GUI.Box(new Rect(10, 10, 200, 60), "MegaBonk Mod [Home to hide]");
                }
            }
            catch (System.Exception ex)
            {
                MelonLogger.Error($"GUI error: {ex.Message}");
            }
        }
    }
}