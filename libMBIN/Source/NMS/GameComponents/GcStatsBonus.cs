﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC, GUID = 0xAB72DDE93DA84883, NameHash = 0xBAC710ADD80D9C59)]
    public class GcStatsBonus : NMSTemplate
    {
        /* 0x0 */ public GcStatsTypes Stat;
        /* 0x4 */ public float Bonus;
        /* 0x8 */ public int Level;
    }
}
