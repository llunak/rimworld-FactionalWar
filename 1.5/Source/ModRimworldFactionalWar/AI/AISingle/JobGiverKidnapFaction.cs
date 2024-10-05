﻿// ******************************************************************
//       /\ /|       @file       JobGiverKidnapFaction.cs
//       \ V/        @brief      行为节点 绑架派系
//       | "")       @author     Shadowrabbit, yingtu0401@gmail.com
//       /  |                    
//      /  \\        @Modified   2021-06-24 23:32:54
//    *(__\_\        @Copyright  Copyright (c) 2021, Shadowrabbit
// ******************************************************************

using JetBrains.Annotations;
using RimWorld;
using Verse;
using Verse.AI;

namespace SR.ModRimWorld.FactionalWar
{
    [UsedImplicitly]
    public class JobGiverKidnapFaction : ThinkNode_JobGiver
    {
        private const float VictimSearchRadiusOngoing = 18f;
        
        protected override Job TryGiveJob(Pawn pawn)
        {
            if (!RCellFinder.TryFindBestExitSpot(pawn, out var c))
            {
                return null;
            }

            if (!KidnapAIUtil.TryFindGoodKidnapVictim(pawn, VictimSearchRadiusOngoing, out var t) ||
                GenAI.InDangerousCombat(pawn))
            {
                return null;
            }

            var job = JobMaker.MakeJob(RimWorld.JobDefOf.Kidnap);
            job.targetA = t;
            job.targetB = c;
            job.count = 1;
            return job;
        }
    }
}