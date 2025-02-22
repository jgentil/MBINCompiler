﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x70, GUID = 0x1C8B8BB10C79EEA7, NameHash = 0x7EBC25FE326CF24B)]
    public class GcMessageProjectileImpact : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Damage;
        /* 0x14 */ public GcDamageType Type;
        /* 0x18 */ public bool Critical;
        /* 0x19 */ public bool Ineffective;
        /* 0x1A */ public bool LaserHeatBoost;
        // size: 0x3
        public enum HitTypeEnum { Shootable, Terrain, Generic }
        /* 0x20 */ public HitTypeEnum HitType;
        /* 0x30 */ public Vector3f PosLocal;
        /* 0x40 */ public Vector3f PosOffset;
        /* 0x50 */ public List<GcImpactCombatEffectData> CombatEffects;
        /* 0x60 */ public List<GcCombatEffectDamageMultiplier> DamageMultipliers;
    }
}
