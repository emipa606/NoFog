using HarmonyLib;
using Verse;

namespace NoFog;

[HarmonyPatch(typeof(Map), nameof(Map.FinalizeInit))]
public static class Map_FinalizeInit
{
    public static bool Prepare()
    {
        return !NoFog.UsingStargate;
    }

    public static void Postfix(Map __instance)
    {
        __instance.fogGrid?.ClearAllFog();
    }
}