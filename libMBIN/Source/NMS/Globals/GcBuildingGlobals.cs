﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x3D0, GUID = 0xC942FEAF55D6265D, NameHash = 0x7B6EECDDCAF6F923)]
    public class GcBuildingGlobals : NMSTemplate
    {
        /* 0x000 */ public Vector3f BuildingPartPreviewOffset;
        /* 0x010 */ public float BuildingPlacementEffectInterpRate;
        /* 0x014 */ public float BuildingPlacementEffectInterpRateSlow;
        /* 0x018 */ public float BuildingPlacementEffectPreviewInterpTime;
        /* 0x01C */ public float BuildingPlacementEffectPostPreviewInterpTime;
        /* 0x020 */ public float BuildingPlacementEffectSpringSlow;
        /* 0x024 */ public float BuildingPlacementEffectSpringFast;
        /* 0x028 */ public float BuildingPartPreviewRadius;
        /* 0x02C */ public float BuildingPartPreviewPitch;
        /* 0x030 */ public float BuildingPartPreviewRotateSpeed;
        [NMS(Size = 0x4)]
        /* 0x034 */ public TkLODDistances[] ActiveLodDistances;
        [NMS(Size = 0x4)]
        /* 0x084 */ public TkLODDistances[] InactiveLodDistances;
        /* 0x0D4 */ public float PowerlineSnapDistance;
        /* 0x0D8 */ public float HologramDistanceMultiplier;
        /* 0x0DC */ public float HologramDistanceMultiplierAlt;
        /* 0x0E0 */ public bool AllowBuildingUsingIntermediates;
        /* 0x0E4 */ public float BuildingWaterMargin;
        /* 0x0E8 */ public float BuildingLineAlphaEnd0;
        /* 0x0EC */ public float BuildingLineAlphaEnd1;
        /* 0x0F0 */ public float BuildingLineAlphaStart;
        /* 0x0F4 */ public float BuildingLineWidth;
        /* 0x0F8 */ public float BuildingLineMoveSpeed;
        /* 0x0FC */ public float BuildingLineResetTime;
        /* 0x100 */ public float BuildingLineOBBShrink;
        /* 0x104 */ public float BuildingLineProjectorWidth;
        /* 0x108 */ public float BuildingLineProjectorLength;
        /* 0x10C */ public int BuildingLineCount;
        /* 0x110 */ public float IconSpringTime;
        /* 0x114 */ public float HoverFadeAlpha;
        /* 0x118 */ public float HoverTime;
        /* 0x11C */ public float HoverVisibilityTime;
        /* 0x120 */ public float HoverFadeTime;
        /* 0x124 */ public float HoverMinToStayActiveTime;
        /* 0x128 */ public float HoverStayActiveTime;
        /* 0x12C */ public float HoverLockedInitTime;
        /* 0x130 */ public float HoverLockedActiveTime;
        /* 0x134 */ public float HoverLockedIconScale;
        /* 0x138 */ public float HoverInactiveSize;
        /* 0x13C */ public float HoverFadeAlphaHmd;
        /* 0x140 */ public float HoverTimeHmd;
        /* 0x144 */ public float HoverVisibilityTimeHmd;
        /* 0x148 */ public float HoverFadeTimeHmd;
        /* 0x14C */ public float HoverMinToStayActiveTimeHmd;
        /* 0x150 */ public float HoverStayActiveTimeHmd;
        /* 0x154 */ public float HoverLockedInitTimeHmd;
        /* 0x158 */ public float HoverLockedActiveTimeHmd;
        /* 0x15C */ public float HoverLockedIconScaleHmd;
        /* 0x160 */ public float HoverInactiveSizeHmd;
        /* 0x164 */ public float LineMinDistance;
        /* 0x168 */ public float LineDistanceRange;
        /* 0x16C */ public float MaxLineLength;
        /* 0x170 */ public float MinLineLength;
        /* 0x174 */ public float MinLineLengthShip;
        /* 0x178 */ public float HeightDiffLineAdjustMin;
        /* 0x17C */ public float HeightDiffLineAdjustMax;
        /* 0x180 */ public float HeightDiffLineAdjustFactor;
        /* 0x184 */ public TkCurveType LineCurve;
        /* 0x188 */ public float BuildingYOffset;
        /* 0x18C */ public float InteractMarkerYOffset;
        /* 0x190 */ public float MinRadius;
        /* 0x194 */ public float FadeRadius;
        /* 0x198 */ public float CloseFadeRadius;
        /* 0x19C */ public float CloseScaleRadius;
        /* 0x1A0 */ public float PlanetSectorSize;
        /* 0x1A4 */ public float LargePropTestRadius;
        /* 0x1A8 */ public float LargePropExclusionRadiusExtension;
        /* 0x1AC */ public float ChanceOfAddingShelter;
        /* 0x1B0 */ public float SectorMessageReshowDistance;
        /* 0x1B4 */ public float SectorMessageCenterDistance;
        /* 0x1B8 */ public float SectorMessageMinTime;
        /* 0x1BC */ public float MinTimeBetweenBuildingEntryMessage;
        /* 0x1C0 */ public float FadeStart;
        /* 0x1C4 */ public float FadeDistance;
        /* 0x1C8 */ public float NearMinAlpha;
        /* 0x1CC */ public float MinAlpha;
        /* 0x1D0 */ public float LineScaleFactor;
        /* 0x1D4 */ public float BuildingNearDistance;
        /* 0x1D8 */ public float BuildingNearArcDistance;
        /* 0x1DC */ public float BuildingVisitDistance;
        /* 0x1E0 */ public float NearMaxLineLength;
        /* 0x1E4 */ public float NearMinLineLength;
        /* 0x1E8 */ public float NearLineScaleFactor;
        /* 0x1EC */ public float MinElevatedHeight;
        /* 0x1F0 */ public float MaxLowHeight;
        /* 0x1F4 */ public float TextStringXOffset;
        /* 0x1F8 */ public float TextTagXOffset;
        /* 0x1FC */ public float TextTagYOffset;
        /* 0x200 */ public float TextTagWidthOffset;
        /* 0x204 */ public float DistanceTextXOffset;
        /* 0x208 */ public float DistanceTagXOffset;
        /* 0x20C */ public float TextTagLength;
        /* 0x210 */ public float DistanceForVisited;
        /* 0x214 */ public float DistanceForTooltip;
        /* 0x218 */ public float SmallIconSize;
        /* 0x21C */ public float LargeIconSize;
        /* 0x220 */ public float LargeIconArrowOffset;
        /* 0x224 */ public float CompassIconSize;
        /* 0x228 */ public float SmallIconArrowOffset;
        /* 0x22C */ public float SpaceMarkerOffset;
        /* 0x230 */ public float SpaceMarkerOffsetPlanet;
        /* 0x234 */ public float SpaceMarkerOffsetSamePlanet;
        /* 0x238 */ public float MarkerLineWidth;
        /* 0x240 */ public Colour MarkerLineColour;
        /* 0x250 */ public float AmountToMoveMarkerRoundSphere;
        /* 0x254 */ public float MarkerTransitionDistance;
        /* 0x258 */ public float SpaceMarkerMinHeight;
        /* 0x25C */ public float SpaceMarkerMaxHeight;
        /* 0x260 */ public float MaxTimeBetweenEvents;
        /* 0x264 */ public float ShowTimeNotDistance;
        /* 0x268 */ public float UnknownBuildingRange;
        /* 0x26C */ public float MaxIconRange;
        /* 0x270 */ public float MarkerTimeIncrease;
        /* 0x274 */ public float FlyingBuildingIconTime;
        /* 0x278 */ public int MinShipScanBuildings;
        /* 0x27C */ public int MaxShipScanBuildings;
        /* 0x280 */ public float MinRadiusForBases;
        /* 0x284 */ public float BaseRadiusExtension;
        /* 0x288 */ public float MaxRadiusForPlanetBases;
        /* 0x28C */ public float MaxRadiusForSpaceBases;
        /* 0x290 */ public float MinRadiusFromFeaturedBases;
        /* 0x294 */ public float BuildingPlacementMaxConnectionLength;
        /* 0x298 */ public float BuildingPlacementMaxDistance;
        /* 0x29C */ public float BuildingPlacementCursorOffset;
        /* 0x2A0 */ public float BuildingPlacementDefaultMinDistance;
        /* 0x2A4 */ public float BuildingPlacementMinDistanceScaleIncrease;
        /* 0x2A8 */ public float BuildingPlacementDefaultMinDistanceVR;
        /* 0x2AC */ public float BuildingPlacementMinDistanceScaleIncreaseVR;
        /* 0x2B0 */ public float BuildingPlacementNumGhostsMinOffset;
        /* 0x2B4 */ public float BuildingPlacementNumGhostsVolume;
        /* 0x2B8 */ public float BuildingPlacementTwistScale;
        /* 0x2BC */ public float BuildingPlacementConeStartRadius;
        /* 0x2C0 */ public float BuildingPlacementConeEndRadius;
        /* 0x2C4 */ public float BuildingPlacementConeEndDistance;
        /* 0x2C8 */ public bool BuildingPlacementEffectEnabled;
        /* 0x2CC */ public float BuildingPlacementEffectDissolveSpeed;
        /* 0x2D0 */ public float BuildingPlacementEffectFadeWaitTime;
        /* 0x2D4 */ public float BuildingPlacementEffectCrossFadeTime;
        /* 0x2D8 */ public float BuildingPlacementEffectHidePlaceholderFadeTime;
        /* 0x2DC */ public float BuildingPlacementEffectHidePlaceholderDistance;
        /* 0x2E0 */ public Vector2f BuildingPlacementScaleMinMax;
        /* 0x2E8 */ public float InactiveVisibleComplexityFactor;
        /* 0x2EC */ public bool DebugForceShowInactives;
        [NMS(Size = 0x4)]
        /* 0x2F0 */ public float[] TotalPlanetFrameTimeForComplexity;
        [NMS(Size = 0x4)]
        /* 0x300 */ public float[] TotalSpaceFrameTimeForComplexity;
        /* 0x310 */ public float MinPercentageNodesBufferFree;
        /* 0x314 */ public float MinLoadingPercentageNodesBufferFree;
        /* 0x318 */ public float PercentagePhysicsComponentsForComplexity;
        /* 0x31C */ public float MaximumComplexityDensity;
        /* 0x320 */ public float ComplexityDensityTestRange;
        /* 0x324 */ public float ComplexityDensitySigmaSquared;
        /* 0x328 */ public float StartCrashSiteMinDistance;
        /* 0x32C */ public float StartCrashSiteMaxDistance;
        /* 0x330 */ public float StartShelterMinDistance;
        /* 0x334 */ public float StartShelterMaxDistance;
        /* 0x338 */ public NMSString0x80 FreighterBaseSpawnOverride;
        /* 0x3B8 */ public bool BaseBuildingTerrainEditBoundsOverride;
        /* 0x3BC */ public float BaseBuildingTerrainEditBaseYOffset;
        /* 0x3C0 */ public float BaseBuildingTerrainEditTopYOffset;
        /* 0x3C4 */ public float BaseBuildingTerrainEditBoundsScalar;
        /* 0x3C8 */ public bool BaseBuildingCamEnabled;
    }
}
