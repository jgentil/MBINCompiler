﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1070, GUID = 0xC833B97E44E39BAB, NameHash = 0xC45203411E9AFE95)]
    public class GcSpaceshipGlobals : NMSTemplate
    {
        /* 0x0000 */ public bool AllowSideScreenPointing;
        /* 0x0001 */ public bool AddShipToCollectionOnEnter;
        /* 0x0002 */ public bool EnablePulseDriveSpaceStationOrient;
        /* 0x0004 */ public float DockingApproachRollHmdMod;
        /* 0x0008 */ public float DockingApproachSpeedHmdMod;
        /* 0x000C */ public float DockingApproachBrakeHmdMod;
        /* 0x0010 */ public float LandingDirectionalSideOffsetFactor;
        /* 0x0014 */ public float LandingHoverOffset;
        /* 0x0018 */ public float LandingMaxSpeed;
        /* 0x001C */ public float LandingMaxAngle;
        /* 0x0020 */ public float LandingMargin;
        /* 0x0024 */ public float LandingObstacleMinHeight;
        /* 0x0028 */ public float LandingTooManyLowPointsFraction;
        /* 0x002C */ public float VignetteAmountAcceleration;
        /* 0x0030 */ public float VignetteAmountTurning;
        /* 0x0034 */ public float PulseDriveBoostDoubleTapTime;
        /* 0x0038 */ public float RudderToRollMultiplierMin;
        /* 0x003C */ public float RudderToRollMultiplierMax;
        /* 0x0040 */ public float RudderToRollMultiplierOpposite;
        /* 0x0044 */ public float RudderToRollMultiplierSpace;
        /* 0x0048 */ public float RudderToRollMultiplierLow;
        /* 0x004C */ public float RudderToRollCutoffRotation;
        /* 0x0050 */ public float RudderToRollUpsideDownRotation;
        /* 0x0054 */ public TkCurveType RudderToRollCurve;
        /* 0x0058 */ public float RudderToRollAngleUpMax;
        /* 0x005C */ public float RudderToRollAngleDownMin;
        /* 0x0060 */ public float RudderToRollAngleDownMax;
        /* 0x0064 */ public float PulseDriveStationApproachAngleMin;
        /* 0x0068 */ public float PulseDriveStationApproachAngleRange;
        /* 0x006C */ public float PulseDriveStationApproachPerpAngleMin;
        /* 0x0070 */ public float PulseDriveStationApproachPerpAngleRange;
        /* 0x0074 */ public float PulseDriveStationApproachOffset;
        /* 0x0078 */ public float PulseDriveStationApproachSlowdown;
        /* 0x007C */ public float PulseDriveStationApproachSlowdownRangeMin;
        /* 0x0080 */ public float PulseDriveStationApproachSlowdownRange;
        /* 0x0084 */ public float HandControllerActiveBlendMinTime;
        /* 0x0088 */ public float HandControllerActiveBlendTime;
        /* 0x008C */ public Vector2f HandControllerValueMultiplier;
        /* 0x0094 */ public Vector2f HandControllerValueMultiplierSpace;
        /* 0x009C */ public Vector2f HandControllerDeadZone;
        /* 0x00A4 */ public Vector2f HandControllerExtents;
        /* 0x00AC */ public float HandControllerXReorientationMove;
        /* 0x00B0 */ public float HandControllerZReorientationMove;
        /* 0x00B4 */ public float HandControllerXReorientation;
        /* 0x00B8 */ public float HandControllerZReorientation;
        /* 0x00BC */ public float HandControllerThrottleDistance;
        /* 0x00C0 */ public float HandControllerThrottleRange;
        /* 0x00C4 */ public float HandControllerThrottleDeadZone;
        /* 0x00C8 */ public float HandControllerDirOffsetAngle;
        /* 0x00CC */ public float HandControllerDirOffsetAngleMove;
        /* 0x00D0 */ public float CockpitRollAngleHmd;
        /* 0x00D4 */ public float CockpitPitchCorrectAngleHmd;
        /* 0x00D8 */ public float CockpitDriftAngleHmd;
        /* 0x00DC */ public float CockpitRollAngle;
        /* 0x00E0 */ public float CockpitPitchCorrectAngle;
        /* 0x00E4 */ public float CockpitDriftAngle;
        /* 0x00E8 */ public float CockpitRollAngleExtra;
        /* 0x00EC */ public float CockpitRollTime;
        /* 0x00F0 */ public float CockpitRollMultiplierCentre;
        /* 0x00F4 */ public float CockpitRollMultiplierOpposite;
        /* 0x00F8 */ public float MaximumDistanceFromShipWhenExiting;
        /* 0x00FC */ public float MaximumHeightWhenExitingShip;
        /* 0x0100 */ public float DistanceFromShipToAllowSpawningOnFreighter;
        /* 0x0104 */ public float FreighterBattleIgnoreFriendlyFireDistance;
        /* 0x0108 */ public bool AltControls;
        /* 0x0109 */ public bool SpaceMapInWorld;
        /* 0x010A */ public bool _3rdPersonShipEnabled;
        /* 0x010B */ public bool AimZoomAuto;
        /* 0x010C */ public bool EnableDepthTestedCrosshairSections;
        /* 0x010D */ public bool CritsFromBehind;
        /* 0x010E */ public bool DrawLineLockTarget;
        /* 0x010F */ public bool ApplyHeightForce;
        /* 0x0110 */ public bool ApplyHeightAlign;
        /* 0x0111 */ public bool DoPreCollision;
        /* 0x0112 */ public bool SpeedTrackModeEnabled;
        /* 0x0114 */ public int TrailMaxNumPointsPerFrameOverride;
        /* 0x0118 */ public float TestTrailSpeed;
        /* 0x011C */ public float TestTrailRadius;
        /* 0x0120 */ public float CockpitExitAnimTime;
        /* 0x0124 */ public float CockpitExitAnimOffset;
        /* 0x0128 */ public TkCurveType CockpitExitAnimCurve;
        /* 0x012C */ public float WingmanSpeedTrackForceMax;
        /* 0x0130 */ public float WingmanSpeedTrackForceMin;
        /* 0x0134 */ public float WingmanSpeedTrackDistance;
        /* 0x0138 */ public float WingmanSpeedTrackOffset;
        /* 0x013C */ public float WingmanSpeedApproachSpeed;
        /* 0x0140 */ public float WingmanSpeedApproachSpeedSpace;
        /* 0x0144 */ public float DockingAttractAlign;
        /* 0x0148 */ public float DockingAttractAlignRange;
        /* 0x0150 */ public Colour LandingEffectSpaceColourOverride;
        /* 0x0160 */ public Colour GroundEffectBuildingColour;
        /* 0x0170 */ public Colour GroundEffectWaterColour;
        /* 0x0180 */ public float GroundNearEffectLightFactor;
        /* 0x0184 */ public float GroundNearEffectWaterLightFactor;
        /* 0x0188 */ public float GroundWaterSpeedFactor;
        /* 0x018C */ public float AtmosphereLightIntensity;
        /* 0x0190 */ public Vector3f AtmosphereLightOffset;
        /* 0x01A0 */ public float OutpostDockSpeedAlignMinDistance;
        /* 0x01A4 */ public float OutpostDockSpeedAlignRange;
        /* 0x01A8 */ public float NearGroundPitchCorrectMinHeight;
        /* 0x01AC */ public float NearGroundPitchCorrectRange;
        /* 0x01B0 */ public float NearGroundPitchCorrectMinHeightRemote;
        /* 0x01B4 */ public float NearGroundPitchCorrectRangeRemote;
        /* 0x01B8 */ public float MiniWarpMarkerApproachSlowdown;
        /* 0x01BC */ public float MiniWarpMarkerAlignSlowdown;
        /* 0x01C0 */ public float MiniWarpMarkerAlignSlowdownRange;
        /* 0x01C4 */ public float MiniWarpAlignSlerp;
        /* 0x01C8 */ public float WarpInTime;
        /* 0x01CC */ public float WarpInFlashTime;
        /* 0x01D0 */ public float WarpInRange;
        /* 0x01D4 */ public float WarpScale;
        /* 0x01D8 */ public float WarpInTimeFreighter;
        /* 0x01DC */ public float WarpInFlashTimeFreighter;
        /* 0x01E0 */ public float WarpInRangeFreighter;
        /* 0x01E4 */ public float WarpScaleFreighter;
        /* 0x01E8 */ public float WarpFadeInTime;
        /* 0x01EC */ public float WarpInLineWidth;
        /* 0x01F0 */ public TkCurveType WarpInCurve;
        /* 0x01F4 */ public float WarpOutRange;
        /* 0x01F8 */ public float WarpOutTime;
        /* 0x01FC */ public float WarpInTimeNexus;
        /* 0x0200 */ public float WarpInFlashTimeNexus;
        /* 0x0204 */ public float WarpInRangeNexus;
        /* 0x0208 */ public float WarpScaleNexus;
        /* 0x020C */ public float WarpNexusRotation;
        /* 0x0210 */ public float WarpNexusPitch;
        /* 0x0214 */ public float WarpNexusDistance;
        /* 0x0218 */ public float NetworkDockSearchRadius;
        /* 0x021C */ public float DirectionDockingIndicatorRange;
        /* 0x0220 */ public float DirectionDockingIndicatorClearAngleRange;
        /* 0x0224 */ public float DirectionDockingIndicatorAngleRange;
        /* 0x0228 */ public float DirectionDockingIndicatorMinHeight;
        /* 0x022C */ public float DirectionDockingIndicatorMaxHeight;
        /* 0x0230 */ public Colour DirectionDockingInRangeColour;
        /* 0x0240 */ public Colour DirectionDockingOutRangeColour;
        /* 0x0250 */ public float DirectionDockingCircleOffset;
        /* 0x0254 */ public float DirectionDockingCircleOffsetExtra;
        /* 0x0258 */ public float DirectionDockingCircleWidth;
        /* 0x025C */ public float DirectionDockingCircleRadius;
        /* 0x0260 */ public float DirectionDockingCircleRadiusExtra;
        /* 0x0264 */ public float DirectionDockingIndicatorSpeed;
        /* 0x0268 */ public TkCurveType DirectionDockingIndicatorCurve;
        /* 0x026C */ public float ExhaustSpeed;
        /* 0x0270 */ public float GroundNearEffectHeight;
        /* 0x0274 */ public float GroundNearEffectRange;
        /* 0x0278 */ public float GroundNearEffectNormalOffset;
        /* 0x027C */ public float GroundNearEffectBuildingFade;
        /* 0x0280 */ public bool TestShipAnims;
        /* 0x0284 */ public float TestShipAnimRoll;
        /* 0x0288 */ public float TestShipAnimThrust;
        /* 0x028C */ public float TestShipAnimPulse;
        /* 0x0290 */ public float TestShipAnimSpace;
        /* 0x0294 */ public GcSpaceshipAvoidanceData Avoidance;
        /* 0x02B8 */ public float DefaultTrailInitialSpeed;
        /* 0x02BC */ public float DefaultTrailSpeedDamping;
        /* 0x02C0 */ public float DefaultTrailMinForwardSpeed;
        /* 0x02C4 */ public float TrailVelocityFactor;
        /* 0x02C8 */ public float ContrailSpeedDamping;
        /* 0x02CC */ public float MaxOverspeedBrake;
        /* 0x02D0 */ public float PostWarpSlowDownTime;
        /* 0x02D4 */ public float PostFreighterWarpTransitionTime;
        /* 0x02D8 */ public float PulseDrivePlanetApproachMinAngle;
        /* 0x02DC */ public float PulseDrivePlanetApproachMaxAngle;
        /* 0x02E0 */ public float PulseDrivePlanetApproachHeight;
        /* 0x02E4 */ public float TestJetsStage1;
        /* 0x02E8 */ public float TestJetsStage2;
        /* 0x02EC */ public float TestJetsBoost;
        /* 0x02F0 */ public float TestTrailThreshold;
        /* 0x02F4 */ public float ContrailDefaultAlpha;
        /* 0x02F8 */ public float EngineJetLightIntensityMultiplier;
        /* 0x02FC */ public float EngineEffectsThrustContribution;
        /* 0x0300 */ public float TestShieldEffect;
        /* 0x0304 */ public float ShieldEffectHitTime;
        /* 0x0308 */ public TkCurveType ShieldEffectHitCurve;
        /* 0x0310 */ public GcScanEffectData ShieldEffectScanData;
        /* 0x0360 */ public float AcrobaticLowFlightLevel;
        /* 0x0364 */ public float _3rdPersonUpOffsetRollChangeSpeed;
        /* 0x0368 */ public float _3rdPersonRollAngle;
        /* 0x036C */ public float _3rdPersonRollAngleDropship;
        /* 0x0370 */ public float _3rdPersonRollAngleScience;
        /* 0x0374 */ public float _3rdPersonRollAngleAlien;
        /* 0x0378 */ public float _3rdPersonPitchAngle;
        /* 0x037C */ public float _3rdPersonYawAngle;
        /* 0x0380 */ public float _3rdPersonYawAngleLateralExtra;
        /* 0x0384 */ public float _3rdPersonAngleSpringTime;
        /* 0x0388 */ public float _3rdPersonAngleMinSpeed;
        /* 0x038C */ public float _3rdPersonAngleSpeedRangePitch;
        /* 0x0390 */ public float _3rdPersonAngleSpeedRangeYaw;
        /* 0x0394 */ public float _3rdPersonLowHeightMin;
        /* 0x0398 */ public float _3rdPersonLowHeightMax;
        /* 0x039C */ public float _3rdPersonLowHeightOffsetVertRotationY;
        /* 0x03A0 */ public float _3rdPersonLowHeightOffsetY;
        /* 0x03A4 */ public float _3rdPersonLowHeightSpringTime;
        /* 0x03A8 */ public float _3rdPersonAvoidanceAdjustPitchFactor;
        /* 0x03AC */ public float _3rdPersonHeightForceAdjustPitchFactor;
        /* 0x03B0 */ public float _3rdPersonAvoidanceAdjustRollFactor;
        /* 0x03B4 */ public float _3rdPersonAvoidanceAdjustYawFactor;
        /* 0x03B8 */ public float _3rdPersonFlashIntensity;
        /* 0x03BC */ public float _3rdPersonFlashDuration;
        /* 0x03C0 */ public float _3rdPersonTransitionTime;
        /* 0x03C4 */ public float _3rdPersonWarpXWander;
        /* 0x03C8 */ public float _3rdPersonWarpYWander;
        /* 0x03CC */ public float _3rdPersonWarpZWander;
        /* 0x03D0 */ public float _3rdPersonWarpWanderStartTime;
        /* 0x03D4 */ public float _3rdPersonWarpWanderSpring;
        /* 0x03D8 */ public float _3rdPersonWarpWanderTimeX;
        /* 0x03DC */ public float _3rdPersonWarpWanderTimeY;
        /* 0x03E0 */ public float _3rdPersonWarpWanderTimeZ;
        /* 0x03E4 */ public TkCurveType _3rdPersonWarpWanderCurve;
        /* 0x03E8 */ public float AvoidancePower;
        /* 0x03EC */ public float AvoidanceDistancePower;
        /* 0x03F0 */ public float CollisionDeflectForce;
        /* 0x03F4 */ public float CollisionAlignStrength;
        /* 0x0400 */ public Vector3f DefaultCentreOffset;
        /* 0x0410 */ public Vector3f DefaultCentreOffsetDropship;
        /* 0x0420 */ public Vector3f DefaultCentreOffsetScientific;
        /* 0x0430 */ public Vector3f DefaultCentreOffsetRoyal;
        /* 0x0440 */ public float WeaponDamagePotentialReferenceRange;
        /* 0x0444 */ public float DirectionBrakeVerticalMultiplier;
        /* 0x0448 */ public float LateralDriftRollAmount;
        /* 0x044C */ public float LateralDriftRange;
        /* 0x0450 */ public float PadTurnSpeed;
        /* 0x0454 */ public float KBThrustSmoothTime;
        /* 0x0458 */ public float HoverTakeoffHeight;
        /* 0x045C */ public float HoverTime;
        /* 0x0460 */ public float HoverAlignTime;
        /* 0x0464 */ public float HoverTimeAlt;
        /* 0x0468 */ public float HoverAlignTimeAlt;
        /* 0x046C */ public float HoverSpeedFactor;
        /* 0x0470 */ public float HoverHeightFactor;
        /* 0x0474 */ public float HoverMinSpeed;
        /* 0x0478 */ public float HoverLandReachedMinTime;
        /* 0x047C */ public float HoverLandReachedDistance;
        /* 0x0480 */ public float HoverLandManeuvreTimeMin;
        /* 0x0484 */ public float HoverLandManeuvreTimeMax;
        /* 0x0488 */ public float HoverLandManeuvreTimeHmdMin;
        /* 0x048C */ public float HoverLandManeuvreTimeHmdMax;
        /* 0x0490 */ public float HoverLandManeuvreBrake;
        /* 0x0494 */ public float LandingOnGroundTip;
        /* 0x0498 */ public bool LandingCheckBuildings;
        /* 0x049C */ public float LandingCheckBuildingRadiusFactor;
        /* 0x04A0 */ public float AutoLevelWaterMargin;
        /* 0x04A4 */ public float AutoLevelWaterTorque;
        /* 0x04A8 */ public float AutoLevelWaterAngle;
        /* 0x04AC */ public float AutoLevelPitchCorrectMargin;
        /* 0x04B0 */ public Vector3f PostCollisionAngularFactor;
        /* 0x04C0 */ public float DrawLineLockTargetLineWidth;
        /* 0x04C4 */ public float DamageFlashScale;
        /* 0x04C8 */ public float DamageFlashMin;
        /* 0x04CC */ public float LandingButtonMinTime;
        /* 0x04D0 */ public float LandingPushNoseUpFactor;
        /* 0x04D4 */ public float GroundHeightSoftForce;
        /* 0x04D8 */ public float GroundHeightSoft;
        /* 0x04DC */ public float GroundHeightSoftHorizontal;
        /* 0x04E0 */ public TkCurveType GroundHeightSoftCurve;
        /* 0x04E4 */ public float GroundHeightHard;
        /* 0x04E8 */ public float GroundHeightHardHorizontal;
        /* 0x04EC */ public TkCurveType GroundHeightHardCurve;
        /* 0x04F0 */ public float GroundHeightPostCollisionMultiplier;
        /* 0x04F4 */ public float GroundHeightPostCollisionMultiplierTime;
        /* 0x04F8 */ public float GroundHeightDownSpeedMultiplier;
        /* 0x04FC */ public float GroundHeightBrakeMultiplier;
        /* 0x0500 */ public float PitchCorrectDownSpeedMinSpeed;
        /* 0x0504 */ public float PitchCorrectDownSpeedRange;
        /* 0x0508 */ public float PitchCorrectDownSpeedSoftAngle;
        /* 0x050C */ public float PitchCorrectDownSpeedMaxDownAngle;
        /* 0x0510 */ public float PitchCorrectDownSpeedHeightMin;
        /* 0x0514 */ public float PitchCorrectDownSpeedHeightMax;
        /* 0x0518 */ public float PitchCorrectCockpitSpring;
        /* 0x051C */ public float PitchCorrectSoftDownAngle;
        /* 0x0520 */ public float PitchCorrectMaxDownAngle;
        /* 0x0524 */ public float PitchCorrectMaxDownAnglePostCollision;
        /* 0x0528 */ public float PitchCorrectSoftDownAnglePostCollision;
        /* 0x052C */ public float PitchCorrectMaxDownAngleWater;
        /* 0x0530 */ public float PitchCorrectSoftDownAngleWater;
        /* 0x0534 */ public float PitchCorrectTimeMin;
        /* 0x0538 */ public float PitchCorrectTimeMax;
        /* 0x053C */ public float PitchCorrectTimeHeight;
        /* 0x0540 */ public float PitchCorrectHeightSpring;
        /* 0x0544 */ public float PitchCorrectHeightMin;
        /* 0x0548 */ public float PitchCorrectHeightMax;
        /* 0x054C */ public TkCurveType PitchCorrectHeightCurve;
        /* 0x0550 */ public TkCurveType LandingCurve;
        /* 0x0554 */ public TkCurveType LandingCurveHeavy;
        /* 0x0558 */ public GcPlayerSpaceshipControlData Control;
        /* 0x06AC */ public GcPlayerSpaceshipControlData ControlLight;
        /* 0x0800 */ public GcPlayerSpaceshipControlData ControlHeavy;
        /* 0x0954 */ public GcPlayerSpaceshipClassBonuses ControlBonusC;
        /* 0x0984 */ public GcPlayerSpaceshipClassBonuses ControlBonusB;
        /* 0x09B4 */ public GcPlayerSpaceshipClassBonuses ControlBonusA;
        /* 0x09E4 */ public GcPlayerSpaceshipClassBonuses ControlBonusS;
        /* 0x0A14 */ public float HaulerTakeOffMod;
        /* 0x0A18 */ public float FighterTakeOffMod;
        /* 0x0A1C */ public float ShuttleTakeOffMod;
        /* 0x0A20 */ public float ExplorerTakeOffMod;
        /* 0x0A24 */ public float RoyalTakeOffMod;
        /* 0x0A30 */ public Colour AlarmLightColour;
        /* 0x0A40 */ public List<Vector3f> AlarmLightOffsets;
        /* 0x0A50 */ public float AlarmLightIntensity;
        /* 0x0A54 */ public float AlarmRate;
        /* 0x0A58 */ public float LockTargetMinDistance;
        /* 0x0A5C */ public float LockTargetRange;
        /* 0x0A60 */ public float LockTargetMinScale;
        /* 0x0A64 */ public float LockTargetMaxScale;
        /* 0x0A68 */ public float AutoLevelMinPitchAngle;
        /* 0x0A6C */ public float AutoLevelMaxPitchAngle;
        /* 0x0A70 */ public float AutoLevelMinAngle;
        /* 0x0A74 */ public float AutoLevelMaxAngle;
        /* 0x0A78 */ public bool AutoEjectOnLanding;
        /* 0x0A79 */ public bool LandedCockpitFreeLook;
        /* 0x0A7C */ public float FrigateTargetLockRange;
        /* 0x0A80 */ public float ResetTargetLockAngle;
        /* 0x0A84 */ public float TargetLockRange;
        /* 0x0A88 */ public float TargetLockNearestAngle;
        /* 0x0A8C */ public float RemotePlayerLockTimeAfterShot;
        /* 0x0A90 */ public Colour TargetLockPassiveColour;
        /* 0x0AA0 */ public Colour TargetLockDangerColour;
        /* 0x0AB0 */ public float ShieldRechargeMinHitTime;
        /* 0x0AB4 */ public float ShieldRechargeRate;
        /* 0x0AB8 */ public float NoBoostStationDistance;
        /* 0x0ABC */ public float NoBoostAnomalyDistance;
        /* 0x0AC0 */ public float NoBoostSpaceAnomalyDistance;
        /* 0x0AC4 */ public float NoBoostFreighterDistance;
        /* 0x0AC8 */ public float NoBoostFreighterAngle;
        /* 0x0ACC */ public float NoBoostShipDistance;
        /* 0x0AD0 */ public float NoBoostShipNearMinTime;
        /* 0x0AD4 */ public float NoBoostShipLastHitTime;
        /* 0x0AD8 */ public float NoBoostCombatEventMinBattleTime;
        /* 0x0ADC */ public float NoBoostCombatEventMinFreighterBattleTime;
        /* 0x0AE0 */ public float NoBoostCombatEventTime;
        /* 0x0AE4 */ public float ThrustDecaySpring;
        /* 0x0AE8 */ public float ThrustDecaySpringCombat;
        /* 0x0AEC */ public float DriftEffectIntensity;
        /* 0x0AF0 */ public float SpeedCoolOffset;
        /* 0x0AF4 */ public float SpeedCoolNormalSpeedAmount;
        /* 0x0AF8 */ public int HitAsteroidDamage;
        /* 0x0AFC */ public float CameraPostWarpFovTime;
        /* 0x0B00 */ public float CameraPostWarpFov;
        /* 0x0B04 */ public float NormalModeTakeOffCostMultiplier;
        /* 0x0B08 */ public float SurvivalTakeOffCostMultiplier;
        /* 0x0B0C */ public float PlayerFreighterClearSpaceRadius;
        /* 0x0B10 */ public float DriftSpring;
        /* 0x0B14 */ public float DriftTurnStrengthMultiplier;
        /* 0x0B18 */ public float DriftTurnBrakeMultiplier;
        /* 0x0B1C */ public float DirectionBrakeVRBoost;
        /* 0x0B20 */ public float TurnRudderStrength;
        /* 0x0B24 */ public float MuzzleLightIntensity;
        /* 0x0B28 */ public float MuzzleAnimSpeed;
        /* 0x0B2C */ public TkHitCurveData MuzzleLightCurve;
        /* 0x0B40 */ public Colour MuzzleLightColour;
        /* 0x0B50 */ public Vector3f DamageLightOffsetTop;
        /* 0x0B60 */ public Vector3f DamageLightOffsetLeft;
        /* 0x0B70 */ public Vector3f DamageLightOffsetRight;
        /* 0x0B80 */ public float DamageLightIntensity;
        /* 0x0B84 */ public TkHitCurveData DamageLightCurve;
        /* 0x0BA0 */ public Colour DamageLightColourShield;
        /* 0x0BB0 */ public Colour DamageLightColour;
        /* 0x0BC0 */ public bool AltAtmosphere;
        /* 0x0BC4 */ public float AsteroidHitAngle;
        /* 0x0BC8 */ public float AsteroidHitAngleBoosting;
        /* 0x0BCC */ public float AimCritAngle;
        /* 0x0BD0 */ public float AimCritMinFwdAngle;
        /* 0x0BD4 */ public float AimCritBehindAngle;
        /* 0x0BD8 */ public float MissileShootTime;
        /* 0x0BDC */ public float CruiseHeight;
        /* 0x0BE0 */ public float CruiseHeightRange;
        /* 0x0BE4 */ public float CruiseOffAngle;
        /* 0x0BE8 */ public float CruiseOffAngleRange;
        /* 0x0BEC */ public float CruiseForce;
        /* 0x0BF0 */ public float HoverMaxSpeed;
        /* 0x0BF4 */ public float HoverStopTime;
        /* 0x0BF8 */ public float LandOffset;
        /* 0x0BFC */ public float AimFoVBoost;
        /* 0x0C00 */ public float AimFoVBoostTime;
        /* 0x0C04 */ public float AimFoVBoostTimeAuto;
        /* 0x0C08 */ public float AimTurnSlower;
        /* 0x0C0C */ public float AimMaxAutoAngle;
        /* 0x0C10 */ public float HoverBrakeStrength;
        /* 0x0C14 */ public float StickyTurnMinAngle;
        /* 0x0C18 */ public float StickyTurnAngleRange;
        /* 0x0C1C */ public float StickyTurnLow;
        /* 0x0C20 */ public float StickyTurnHigh;
        /* 0x0C24 */ public float StickyStickAngle;
        /* 0x0C28 */ public float ShipMotionDeadZone;
        /* 0x0C2C */ public Vector2f DeathSpinRoll;
        /* 0x0C34 */ public Vector2f DeathSpinPitch;
        /* 0x0C3C */ public int MiniWarpLinesNum;
        /* 0x0C40 */ public float MiniWarpLinesSpacing;
        /* 0x0C44 */ public float MiniWarpLinesOffset;
        /* 0x0C48 */ public float MiniWarpLinesHeight;
        /* 0x0C4C */ public float GravityDropMinHeight;
        /* 0x0C50 */ public float GravityDropMaxForceHeight;
        /* 0x0C54 */ public float GravityDropMaxHeight;
        /* 0x0C58 */ public float GravityDropForce;
        /* 0x0C5C */ public GcPlayerStickData StickData;
        /* 0x0C78 */ public float ResourceCollectOffset;
        /* 0x0C7C */ public float AimSpeedTrackDistance;
        /* 0x0C80 */ public float AimSpeedTrackForce;
        /* 0x0C84 */ public float CombatBoostMultiplier;
        /* 0x0C88 */ public float CombatBoostTurnDamp;
        /* 0x0C8C */ public float MarkerEventTime;
        /* 0x0C90 */ public int GunAmmoMultiplier;
        /* 0x0C98 */ public List<GcPlayerSpaceshipAim> LaserAimArray;
        /* 0x0CA8 */ public int LaserAimLevel;
        /* 0x0CB0 */ public List<GcPlayerSpaceshipAim> GunAimArray;
        /* 0x0CC0 */ public int TakeOffCost;
        /* 0x0CC4 */ public int LandingCost;
        /* 0x0CC8 */ public int GunAimLevel;
        /* 0x0CCC */ public GcPlayerSpaceshipAim MissileAim;
        /* 0x0CE4 */ public float MissileLockSpeedUp;
        /* 0x0CE8 */ public float MissileLockTime;
        /* 0x0CEC */ public float AutoPilotAlignStrength;
        /* 0x0CF0 */ public float AutoPilotSmallShipAlignStrength;
        /* 0x0CF4 */ public float FreighterApproachDistanceMin;
        /* 0x0CF8 */ public float FreighterApproachDistanceMax;
        /* 0x0CFC */ public float FreighterApproachSpeedDamper;
        /* 0x0D00 */ public float FreighterApproachExtraMargin;
        /* 0x0D04 */ public float MiniWarpShakeStrength;
        /* 0x0D08 */ public float MiniWarpPlanetRadius;
        /* 0x0D0C */ public float MiniWarpStationRadius;
        /* 0x0D10 */ public float MiniWarpFuelTime;
        /* 0x0D14 */ public float MiniWarpAlignStrength;
        /* 0x0D18 */ public float MiniWarpChargeTime;
        /* 0x0D1C */ public float MiniWarpSpeed;
        /* 0x0D20 */ public float MiniWarpTopSpeedTime;
        /* 0x0D24 */ public float MiniWarpTime;
        /* 0x0D28 */ public float MiniWarpCooldownTime;
        /* 0x0D2C */ public float MiniWarpStoppingMarginPlanet;
        /* 0x0D30 */ public float MiniWarpMinPlanetDistance;
        /* 0x0D34 */ public float MiniWarpStoppingMarginStation;
        /* 0x0D38 */ public float MiniWarpTrackingMargin;
        /* 0x0D3C */ public float MiniWarpExitSpeed;
        /* 0x0D40 */ public float MiniWarpExitSpeedStation;
        /* 0x0D44 */ public float MiniWarpExitTime;
        /* 0x0D48 */ public float MiniWarpHUDArrowAttractAngle;
        /* 0x0D4C */ public float MiniWarpHUDArrowAttractAngleStation;
        /* 0x0D50 */ public float MiniWarpHUDArrowAttractAngleOtherPlayerStuff;
        /* 0x0D54 */ public float MiniWarpHUDArrowAttractAngleSaveBeacon;
        /* 0x0D58 */ public float MiniWarpHUDArrowAttractAngleDense;
        /* 0x0D5C */ public int MiniWarpHUDArrowNumMarkersToBeDense;
        /* 0x0D60 */ public TkCurveType MiniWarpCurve;
        /* 0x0D64 */ public float MiniWarpFlashIntensity;
        /* 0x0D68 */ public float MiniWarpFlashDuration;
        /* 0x0D6C */ public float MiniWarpFlashDelay;
        /* 0x0D70 */ public float MiniWarpNoAsteroidRadius;
        /* 0x0D74 */ public float BoostNoAsteroidRadius;
        /* 0x0D78 */ public float ShipHeatAlertTime;
        /* 0x0D7C */ public float LaserOverheatTime;
        /* 0x0D80 */ public float LaserOverheatDownTime;
        /* 0x0D84 */ public float LaserCoolFactor;
        /* 0x0D88 */ public float LaserFireTime;
        /* 0x0D8C */ public float LaserWaitTime;
        /* 0x0D90 */ public float ProjectileOverheatTime;
        /* 0x0D94 */ public float ProjectileFireRate;
        /* 0x0D98 */ public float ProjectileReloadTime;
        /* 0x0D9C */ public int ProjectileClipSize;
        /* 0x0DA0 */ public float SummonShipAnywhereHeightOffset;
        /* 0x0DA4 */ public float SummonShipAnywhereFwdOffset;
        /* 0x0DA8 */ public float SummonShipAnywhereRangeMax;
        /* 0x0DAC */ public float SummonShipAnywhereRangeMin;
        /* 0x0DB0 */ public float SummonShipHeightOffset;
        /* 0x0DB4 */ public float SummonShipApproachOffset;
        /* 0x0DB8 */ public float LandingHelperMinAngle;
        /* 0x0DBC */ public float LandingHelperTurnTime;
        /* 0x0DC0 */ public float LandingHelperRollTime;
        /* 0x0DC4 */ public float AnomalyStationMaxApproachSpeed;
        /* 0x0DC8 */ public float TakeOffSphereCastLength;
        /* 0x0DCC */ public float TakeOffSphereCastRadiusMul;
        /* 0x0DD0 */ public float LandGroundTakeOffTime;
        /* 0x0DD4 */ public float LandLookingForward;
        /* 0x0DD8 */ public float LandHeightThreshold;
        /* 0x0DDC */ public float LandWidthThreshold;
        /* 0x0DE0 */ public float LandSlopeMax;
        /* 0x0DE4 */ public float LandingAreaRadius;
        /* 0x0DE8 */ public float LandingAreaFloorOffset;
        /* 0x0DEC */ public float TargetLockTime;
        /* 0x0DF0 */ public float TargetLockChangeTime;
        /* 0x0DF4 */ public float TargetLockLoseTime;
        /* 0x0DF8 */ public float BoostChargeRate;
        /* 0x0DFC */ public float DamageMinHitTime;
        /* 0x0E00 */ public float DamageMaxHitTime;
        /* 0x0E04 */ public float DamageMinWoundTime;
        /* 0x0E08 */ public float SpaceBrakeMinAngularSpeed;
        /* 0x0E0C */ public float SpaceBrakeAngularRange;
        /* 0x0E10 */ public float CollisionSpeedDamageAmount;
        /* 0x0E14 */ public float CollisionDeflectTime;
        /* 0x0E18 */ public float CollisionDeflectDamping;
        /* 0x0E1C */ public float CollisionDeflectNormalFactor;
        /* 0x0E20 */ public float CollisionAsteroidDamp;
        /* 0x0E24 */ public float CollisionGroundDamp;
        /* 0x0E28 */ public float CollisionDistance;
        /* 0x0E2C */ public float CollisionDistanceGround;
        /* 0x0E30 */ public float CollisionDistanceAsteroid;
        /* 0x0E34 */ public float CollisionDistanceAsteroidSide;
        /* 0x0E38 */ public float CollisionDistanceSpaceships;
        /* 0x0E3C */ public float DeflectDistance;
        /* 0x0E40 */ public float DeflectAlignTimeMin;
        /* 0x0E44 */ public float DeflectAlignTimeMax;
        /* 0x0E48 */ public TkCurveType DeflectCurve;
        /* 0x0E4C */ public float CollisionRadiusMultiplier;
        /* 0x0E50 */ public float GroundHeightHardTimeMin;
        /* 0x0E54 */ public float GroundHeightHardTimeMax;
        /* 0x0E58 */ public float GroundHeightPostCollisionDamper;
        /* 0x0E5C */ public float GroundHeightSpeedLength;
        /* 0x0E60 */ public float GroundHeightSpeedAngle;
        /* 0x0E64 */ public float GroundHeightSpeedAngleRange;
        /* 0x0E68 */ public int GroundHeightNumRays;
        /* 0x0E6C */ public float GroundHeightSmoothTime;
        /* 0x0E70 */ public float LinearDamping;
        /* 0x0E74 */ public float AngularDamping;
        /* 0x0E78 */ public float DirectionDockingAngle;
        /* 0x0E7C */ public float DirectionDockTime;
        /* 0x0E80 */ public float DirectionDockingInfoRange;
        /* 0x0E84 */ public float LootAttractDistance;
        /* 0x0E88 */ public float LootAttractTime;
        /* 0x0E8C */ public float LootDampForce;
        /* 0x0E90 */ public float LootCollectDistance;
        /* 0x0E94 */ public float GunOffset3rdPersonMultiplier;
        /* 0x0EA0 */ public Vector3f GunOffsetLeft;
        /* 0x0EB0 */ public Vector3f GunOffsetRight;
        /* 0x0EC0 */ public Vector3f GunOffsetLeft2;
        /* 0x0ED0 */ public Vector3f GunOffsetRight2;
        /* 0x0EE0 */ public Vector3f GunOffset3rdPersonLeft;
        /* 0x0EF0 */ public Vector3f GunOffset3rdPersonRight;
        /* 0x0F00 */ public GcPlayerSpaceshipWarpData Warp;
        /* 0x0F30 */ public float DockingRotateSpeed;
        /* 0x0F34 */ public float DockingRotateSpeedVR;
        /* 0x0F38 */ public float EjectAnimSwitchPoint;
        /* 0x0F3C */ public float EjectAnimSpeedFactor;
        /* 0x0F40 */ public float ShipDifferentRepelRange;
        /* 0x0F44 */ public float ShipDifferentRepelAmount;
        /* 0x0F48 */ public float AtmosphereSpeed;
        /* 0x0F4C */ public float AtmosphereAngle;
        /* 0x0F50 */ public float DroneAlignUpTime;
        /* 0x0F54 */ public float DroneDustHeight;
        /* 0x0F58 */ public float DroneMinHeight;
        /* 0x0F5C */ public float DroneHeightAdjust;
        /* 0x0F60 */ public float FreighterSpeed;
        /* 0x0F64 */ public float DroneWarpTime;
        /* 0x0F68 */ public float DroneWarpMinForce;
        /* 0x0F6C */ public float DroneWarpMaxForce;
        /* 0x0F70 */ public Vector3f CockpitScale;
        /* 0x0F80 */ public float ShakePowerScaler;
        /* 0x0F84 */ public float ShakeSpeed;
        /* 0x0F88 */ public float ShakeMaxPower;
        /* 0x0F8C */ public float ShakeMaxSpeed;
        /* 0x0F90 */ public float ShakeAlignBrake;
        /* 0x0F94 */ public float WingmanAtTimeStart;
        /* 0x0F98 */ public float WingmanAtTime;
        /* 0x0F9C */ public float WingmanAtTimeBack;
        /* 0x0FA0 */ public float WingmanPerpTime;
        /* 0x0FA4 */ public float WingmanAttackOffset;
        /* 0x0FA8 */ public float WingmanAttackRange;
        /* 0x0FAC */ public float WingmanAttackMinRange;
        /* 0x0FB0 */ public float WingmanAttackAngle;
        /* 0x0FB4 */ public float WingmanViewerAngle;
        /* 0x0FB8 */ public float WingmanAttackAimAngle;
        /* 0x0FBC */ public float WingmanAttackTime;
        /* 0x0FC0 */ public float WingmanAttackTimeout;
        /* 0x0FC4 */ public float WingmanAttackCoolTime;
        /* 0x0FC8 */ public float WingmanSpawnDist;
        /* 0x0FCC */ public float WingmanAlign;
        /* 0x0FD0 */ public float WingmanAngle;
        /* 0x0FD4 */ public float WingmanAngle2;
        /* 0x0FD8 */ public float WingmanRadius;
        /* 0x0FDC */ public float WingmanFwd1;
        /* 0x0FE0 */ public float WingmanFwd2;
        /* 0x0FE4 */ public float DronePlanetAttackRange;
        /* 0x0FE8 */ public float DronePlanetAttackMinRange;
        /* 0x0FEC */ public float DroneShootTime;
        /* 0x0FF0 */ public float DroneAlertAngle;
        /* 0x0FF4 */ public float DroneAlertRange;
        /* 0x0FF8 */ public float DronePatrolRadius;
        /* 0x0FFC */ public float DroneMoveArrivedRange;
        /* 0x1000 */ public float DronePatrolTime;
        /* 0x1004 */ public float ShipEnterRange;
        /* 0x1008 */ public float ShipEnterAngle;
        /* 0x100C */ public float ShipEnterTransitionTime;
        /* 0x1010 */ public float ShipEnterSpeed;
        /* 0x1014 */ public float ShipEnterMinTime;
        /* 0x1018 */ public List<NMSString0x80> ShipModels;
        /* 0x1028 */ public float HUDBoostUpgradeMultiplier;
        /* 0x102C */ public float LaunchThrustersRegenTimePeriod;
        /* 0x1030 */ public float LaunchThrustersMinimumSummonPercentage;
        /* 0x1034 */ public float LaunchThrustersSummonCostMultiplier;
        /* 0x1038 */ public float SpeedUpDistanceThreshold;
        /* 0x103C */ public float SpeedUpDistanceFadeThreshold;
        /* 0x1040 */ public float SpeedUpVelocityThreshold;
        /* 0x1044 */ public float SpeedUpVelocityCoeff;
        /* 0x1048 */ public float MaxSpeedUpDistance;
        /* 0x104C */ public float MaxSpeedUpVelocity;
        /* 0x1050 */ public float StickLandThreshold;
        /* 0x1054 */ public float StickPulseThreshold;
        /* 0x1060 */ public Vector3f StickAnimationDamping;
    }
}
