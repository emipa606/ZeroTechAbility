using Verse;

namespace LingGame;

public class Hediff_FalsePawn : HediffWithComps
{
    public override void Notify_PawnDied(DamageInfo? dinfo, Hediff culprit = null)
    {
        base.Notify_PawnDied(dinfo, culprit);
        if (pawn.Corpse.Spawned)
        {
            pawn.Corpse.Destroy();
        }
    }
}