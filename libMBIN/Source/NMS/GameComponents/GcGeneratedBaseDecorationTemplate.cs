﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB0, GUID = 0x0, NameHash = 0x6370110DC5DC47D2)]
    public class GcGeneratedBaseDecorationTemplate : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public TkTextureResource TemplateScene;
        /* 0x94 */ public float Probability;
        /* 0x98 */ public int MaxPerRoom;
        public enum DecorationLayerEnum { Stairs, Corridor, Room, Door, Decoration1, Decoration2, Decoration3, DecoratonCorridor };
        /* 0x9C */ public DecorationLayerEnum DecorationLayer;
        /* 0xA0 */ public List<int> InvalidRoomIndexes;
    }
}
