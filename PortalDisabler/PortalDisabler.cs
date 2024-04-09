﻿using BepInEx;
using Fusion;
using UnityEngine;
using PortalDisabler.Patch;

namespace PortalDisabler
{
    // Mod d'exemple qui permet à un joueur de péter sur commande en appuyant sur la touche P
    // de son clavier. Vous pouvez vous en servir comme point de départ pour créer vos mods sur
    // Lycans.

    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    [BepInProcess("Lycans.exe")]
    public class PortalDisabler : BaseUnityPlugin
    {
        // Le GUID du plugin doit être unique au plugin que vous créez
        // Il doit également être lisible car est utilisé dans le nom des fichiers de config
        // Changez le nom d'auteur et le nom du plugin afin que le GUID soit correctement
        // initialisé pour votre mod
        public const string PLUGIN_GUID = $"{PLUGIN_AUTHOR}.{PLUGIN_NAME}";
        public const string PLUGIN_AUTHOR = "LloydHawkeye";
        public const string PLUGIN_NAME = "PortalDisabler";
        public const string PLUGIN_VERSION = "1.0.0";

        private void Awake()
        {
            // Initialise le logger global du plugin
            Log.Init(Logger);
            PortalPatch.patch();
        }
    }
}