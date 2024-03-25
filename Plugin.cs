using BepInEx;
using System;
using UnityEngine;

namespace Mod2
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        void Awake() => Application.Quit(); 
    }
}
