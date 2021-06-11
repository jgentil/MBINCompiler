﻿using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x7358A5D1F847C78, NameHash = 0x18CD621AAAB1F01D)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Facing;
        // size: 0x8
        public enum TeleporterTypeEnum { Base, Spacestation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix, OnNexus, SpacestationFixPosition }
        public TeleporterTypeEnum TeleporterType;
        /* 0x44 */ public NMSString0x40 Name;
        /* 0x84 */ public bool CalcWarpOffset;
        /* 0x85 */ public bool IsFeatured;
    }
}
