﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0xFDE049CFFDF6F695, NameHash = 0x326A8803E3B79519)]
    public class GcMissionConditionInCombat : NMSTemplate
    {
        // size: 0x7
        public enum CombatTypeEnum { GroundCombat, SpaceCombat, FiendCombat, BigFishFiendCombat, CorruptedSentinelCombat,
            GroundWormCombat, RewardEncounter
        }
        /* 0x00 */ public CombatTypeEnum CombatType;
        /* 0x08 */ public NMSString0x20A OverrideOSDMessage;
        /* 0x28 */ public bool CheckAllFireteamMembers;
    }
}
