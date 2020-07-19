﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x181429458781FD95, NameHash = 0x1186D86C82D48E4E)]
    public class GcFreighterDungeonParams : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Name;
        /* 0x10 */ public GcDungeonGenerationParams DungeonParams;
    }
}
