﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x190, GUID = 0x4328513D6EA21CD1, NameHash = 0xE6D4EE849D2F9101)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        // maybe the first 0xA elements of GcQuickMenuActions.QuickMenuActionsEnum?
        // or the 0xA 'Saved' GcQuickMenuActions as the name says?
        [NMS(Size = 0xA)]
        /* 0x0 */ public GcQuickMenuActionSaveData[] KeyActions;
    }
}
