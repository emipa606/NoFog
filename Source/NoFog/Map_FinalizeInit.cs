using HarmonyLib;
using Verse;

namespace NoFog;

[HarmonyPatch(typeof(Map), "FinalizeInit")]
public static class Map_FinalizeInit
{
    public static void Postfix(Map __instance)
    {
        __instance.fogGrid?.ClearAllFog();
    }
}