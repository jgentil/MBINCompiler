﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xA8, GUID = 0xCC7FC0FE5B81DBE1, NameHash = 0xEF85A351ABA84D63)]
    public class GcGrabbableData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string LocatorName;
        /* 0x20 */ public float GrabRadius;
        /* 0x24 */ public float AttachTime;
        /* 0x28 */ public float ReleaseRadius;
        /* 0x2C */ public float DetachTime;
        /* 0x30 */ public GcHand Hand;
        /* 0x34 */ public Vector2f RotationLimits;
        /* 0x3C */ public bool AllowOtherWayUp;
        /* 0x3D */ public bool AutoGrab;
        /* 0x40 */ public float ToggleGrabTime;
        public enum GrabTypeEnum { Default, EjectHand, ControlStickLeft, ControlStickRight }
        /* 0x44 */ public GrabTypeEnum GrabType;
        [NMS(Size = 0x10)]
        /* 0x48 */ public string HandPose;
        [NMS(Size = 0x20)]
        /* 0x58 */ public string MovementStartLocator;
        [NMS(Size = 0x20)]
        /* 0x78 */ public string MovementEndLocator;
        /* 0x98 */ public float MovementMaxSpeed;
        /* 0x9C */ public float MovementReturnSpeed;
        /* 0xA0 */ public float MovementRequiredForActivation;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xAC */ public byte[] EndPadding;
    }
}
