﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x12B8A9683D0E67A4, NameHash = 0x2BFE76ABF5398879)]
    public class GcGameMode : NMSTemplate
    {
		public enum PresetGameModeEnum { Unspecified, Normal, Creative, Survival, Ambient, Permadeath, Seasonal }
		public PresetGameModeEnum PresetGameMode;
    }
}
