﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2D8, GUID = 0x7CD92589ED95F1A0, NameHash = 0x89CF360B576FF51D)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        public GcFrigateStats[] FrigateClass;
    }
}
