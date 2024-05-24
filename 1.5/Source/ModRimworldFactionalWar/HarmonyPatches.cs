using HarmonyLib;
using Verse;

namespace SR.ModRimWorld.FactionalWar
{
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        private static Harmony _harmonyInstance;
        public static Harmony HarmonyInstance { get { return _harmonyInstance; } }

        static HarmonyPatches()
        {
            _harmonyInstance = new Harmony("com.shadowrabbit.factionalwar.saveourships2.filterspacemap");
            _harmonyInstance.PatchAll();
        }
    }
}
