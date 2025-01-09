using System.Reflection;
using HarmonyLib;
using Verse;

namespace NoFog;

[StaticConstructorOnStartup]
public static class NoFog
{
    static NoFog()
    {
        new Harmony("Mlie.NoFog").PatchAll(Assembly.GetExecutingAssembly());
    }
}