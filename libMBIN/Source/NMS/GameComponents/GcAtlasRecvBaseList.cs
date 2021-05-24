﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x29046730D3CB288A, NameHash = 0xA756A03382448724)]
    public class GcAtlasRecvBaseList : NMSTemplate
    {
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00 */ public byte[] Padding0;
        /* 0x08 */ public ulong ClientUserdata;
        /* 0x10 */ public int NumberOfBases;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public List<GcPersistentBase> Bases;
        /* 0x28 */ public List<GcPersistentTerrainEdits> BaseTerrainEdits;
    }
}
