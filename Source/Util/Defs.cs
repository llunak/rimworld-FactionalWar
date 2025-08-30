// Modified by llunak, l.lunak@centrum.cz .

using Verse;
using RimWorld;

namespace SR.ModRimWorld.FactionalWar.Util
{
    [DefOf]
    public static class DefsOf
    {
        public static PawnsArrivalModeDef SrTwoFactionsEdgeWalkIn;
        public static RaidStrategyDef SrFactionFirst;

        static DefsOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(DefsOf));
        }
    }
}
