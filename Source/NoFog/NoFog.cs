using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoFog;

[StaticConstructorOnStartup]
public static class NoFog
{
    public static bool UsingStargate;

    static NoFog()
    {
        UsingStargate = ModsConfig.IsActive("CCYT.StargatesMod");
        new Harmony("Mlie.NoFog").PatchAll(Assembly.GetExecutingAssembly());
    }
}