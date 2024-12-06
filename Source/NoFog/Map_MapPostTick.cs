using System.Collections.Generic;
using HarmonyLib;
using Verse;

namespace NoFog;

[HarmonyPatch(typeof(Map), nameof(Map.MapPostTick))]
public static class Map_MapPostTick
{
    private static readonly HashSet<Map> doneMaps = [];

    public static bool Prepare()
    {
        return NoFog.UsingStargate;
    }

    public static void Postfix(Map __instance)
    {
        if (doneMaps.Contains(__instance))
        {
            return;
        }

        if (Find.CurrentMap != __instance)
        {
            return;
        }

        __instance.fogGrid?.ClearAllFog();
        doneMaps.Add(__instance);
    }
}