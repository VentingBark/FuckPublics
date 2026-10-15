using BepInEx;
using FuckPublics.Patches;
using FuckPublics.Utilities;
using UnityEngine;
using Photon.Pun;
using UnityEngine.InputSystem;

namespace FuckPublics;

[BepInPlugin(Constants.Name, Constants.Guid, Constants.Version)]
public class Plugin : BaseUnityPlugin
{
    private void Start()
    {
        HarmonyPatches.Patch();
        GorillaTagger.OnPlayerSpawned(() => MethodUtilities.Attempt(OnPlayerSpawned));
    }

    private void OnPlayerSpawned()
    {
        Debug.Log("Hello world!");
    }
    void Update()
    {
        if (PhotonNetwork.InRoom)
        {
            Application.Quit();
            
        }
    }
}
