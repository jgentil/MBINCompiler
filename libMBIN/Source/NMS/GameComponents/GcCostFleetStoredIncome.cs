﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0xA071C4C907111C11, NameHash = 0x77F73B95EA71A04C)]
    public class GcCostFleetStoredIncome : NMSTemplate
    {
        /* 0x0 */ public GcFrigateClass Class;
        /* 0x4 */ public int RequiredAmount;
    }
}
