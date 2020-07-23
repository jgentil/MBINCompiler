﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x7840, GUID = 0x943E994E131C09B0)]
    public class GcVehicleGlobals : NMSTemplate
    {
        /* 0x0 */ public float VehicleSolarRegenFactor;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4 */ public byte[] Padding4;
        [NMS(Size = 0x10)]
        /* 0x8 */ public string VehicleStrongLaser;
        [NMS(Size = 0x10)]
        /* 0x18 */ public string MechStrongLaser;
        /* 0x28 */ public bool UseFirstPersonCamera;
		/* 0x2C */ public float LevelVehicleCameraFactor;
		/* 0x30 */ public bool ShowAllCheckpoints;
		/* 0x34 */ public float ControlStickRecenterSpeedDegPerSec;
		/* 0x38 */ public float SteeringWheelPushRange;
		/* 0x3C */ public float SteeringWheelPitchAngle;
		/* 0x40 */ public float SteeringWheelSpringBothHands;
		/* 0x44 */ public float SteeringWheelSpringOneHand;
		/* 0x48 */ public float SteeringWheelCentreOffset;
		/* 0x4C */ public TkCurveType SteeringWheelOutputCurve;
		/* 0x50 */ public float RemoteBoostingEffectTimeout;
		/* 0x54 */ public float TestFrictionStat;
		/* 0x58 */ public float TestSkidFrictionStat;
		/* 0x5C */ public bool TestAnims;
		/* 0x60 */ public float TestAnimThrust;
		/* 0x64 */ public float TestAnimBoost;
		/* 0x68 */ public float TestAnimTurn;
        /* 0x6C */ public float VisualTurnUnderwaterSpring;
		/* 0x70 */ public float VisualTurnSpring;
		/* 0x80 */ public Colour DefaultBoosterColour;
		/* 0x90 */ public float WheelDustColourLightFactor;
		/* 0x94 */ public Vector2f MechMovementStickSpeedLimit;
		/* 0x9C */ public Vector2f MechLookStickSpeedLimit;
		/* 0xA4 */ public bool MechAltJumpMode;
		/* 0xA8 */ public float MechContrailAlpha;
		/* 0xAC */ public float MechJetpackJetScaleTime;
        [NMS(Size = 0x10)]
		/* 0xB0 */ public string MechJetpackEffect;
		/* 0xC0 */ public float MechTurnSpeed;
		/* 0xC4 */ public float MechJetpackTurnSpeed;
		/* 0xD0 */ public Vector3f MechTurretAngleLmits;
		/* 0xE0 */ public float MechTurretTurnTimeGround;
		/* 0xE4 */ public float MechTurretMaxAngleGround;
		/* 0xE8 */ public float MechTurretTurnTimeAir;
		/* 0xEC */ public float MechTurretMaxAngleAir;
		/* 0xF0 */ public float MechTurretTimeVRModifier;
		/* 0x100 */ public Vector3f MechCrouchOffset;
		/* 0x110 */ public float MechCoGAdjustTimeWindUp;
        /* 0x114 */ public float MechCoGAdjustTimeAir;
		/* 0x118 */ public float MechCoGAdjustTimeLand;
		/* 0x11C */ public float MechCrouchTime;
		/* 0x120 */ public float MechWalkToRunTimeIdle;
		/* 0x124 */ public float MechWalkToRunTimeSkid;
		/* 0x128 */ public float MechArmSwingAngleWalk;
		/* 0x12C */ public float MechArmSwingPhaseWalk;
		/* 0x130 */ public TkCurveType MechArmSwingCurveWalk;
		/* 0x134 */ public float MechArmSwingAngleFastWalk;
		/* 0x138 */ public float MechArmSwingPhaseFastWalk;
		/* 0x13C */ public TkCurveType MechArmSwingCurveFastWalk;
		/* 0x140 */ public float MechLandBrake;
		/* 0x144 */ public float MechJetpackStrafeStrength;
		/* 0x148 */ public float MechJetpackLandTime;
		/* 0x14C */ public float MechJetpackForce;
		/* 0x150 */ public float MechJetpackBrake;
		/* 0x154 */ public float MechJetpackMaxSpeed;
		/* 0x158 */ public float MechJetpackMaxUpSpeed;
		/* 0x15C */ public float MechJetpackUpForce;
		/* 0x160 */ public float MechJetpackAvoidGroundForce;
		/* 0x164 */ public float MechJetpackFallForce;
		/* 0x168 */ public float MechJetpackAvoidGroundProbeLength;
		/* 0x16C */ public float MechJetpackIgnitionForce;
		/* 0x170 */ public float MechJetpackIgnitionTime;
		/* 0x174 */ public float MechJetpackMaxCoGAdjustX;
		/* 0x178 */ public float MechCameraOffsetTime;
		/* 0x17C */ public float MechCameraOffsetAmount;
		/* 0x180 */ public float MechJetpackDrainRate;
		/* 0x184 */ public float MechJetpackFillRate;
		/* 0x188 */ public float MechDefaultBlendTime;
		/* 0x18C */ public float MechSpeedBlendTime;
		/* 0x190 */ public float MechLandBlendTime;
		/* 0x194 */ public float MechJumpBlendTime;
		/* 0x198 */ public float MechJumpFlyBlendTime;
		/* 0x19C */ public float MechJumpDownBlendTime;
		/* 0x1A0 */ public float MechIdleLowBlendTime;
		/* 0x1A4 */ public float MechIdleLowDelay;
		/* 0x1A8 */ public float MechIdleStopDelay;
		/* 0x1AC */ public float MechFirstPersonMaxTurnTurret;
		/* 0x1B0 */ public float MechFirstPersonMaxLookTurret;
		/* 0x1B4 */ public float MechFirstPersonCrouchAmount;
		/* 0x1B8 */ public float MechPowerUpTime;
		/* 0x1BC */ public float MechCockPitBobX;
		/* 0x1C0 */ public float MechCockPitBobY;
		/* 0x1C4 */ public float MechCockPitBobPitch;
		/* 0x1C8 */ public float MechCockPitBobRoll;
		/* 0x1CC */ public float MechCockPitBobYaw;
		/* 0x1D0 */ public float MechCockPowerDownY;
		/* 0x1D4 */ public float MechTitanFallHeight;
		/* 0x1D8 */ public float MechTitanFallTerrainEditSize;
		/* 0x1DC */ public float MechTitanFallTerrainEditOffset;
		/* 0x1E0 */ public float MechTitanFallLandIdleTime;
		/* 0x1E4 */ public float MechTitanFallLandIntroTime;
		/* 0x1E8 */ public float MechTitanFallCameraShakeDist;
		/* 0x1EC */ public float MechLandCameraShakeDist;
		/* 0x1F0 */ public float MechFootprintFadeTime;
		/* 0x1F4 */ public float MechFootprintFadeDist;
		/* 0x1F8 */ public float MechWeaponInterpSpeed;
		/* 0x1FC */ public float WeaponInterpSpeed;
		/* 0x200 */ public float SubmarineMinSummonDepth;
		/* 0x204 */ public float SubmarineEjectRadius;
        /* 0x208 */ public float SubmarineEjectDownOffset;
		/* 0x20C */ public float SubmarineFirstPersonSteeringSensitivity;
		/* 0x210 */ public float FirstPersonSteeringAdditionalForward;
		/* 0x214 */ public float FirstPersonSteeringAdditionalForwardThreshold;
		/* 0x218 */ public float FirstPersonSteeringAdditionalReverseThreshold;
		/* 0x21C */ public float FirstPersonSteeringMinThrottleHardLeftRight;
		/* 0x220 */ public float FirstPersonSteeringLowSpeedTurnDamping;
		/* 0x230 */ public Vector3f FirstPersonNonVRCameraOffset;
		/* 0x240 */ public Vector3f FirstPersonNonVRCameraOffsetMech;
        /* 0x0250 */ public float UnderwaterBuoyancySurfaceOffset;
        /* 0x0254 */ public float UnderwaterBuoyancyRange;
        /* 0x0258 */ public float UnderwaterSummonSurfaceOffset;
        /* 0x025C */ public float UnderwaterSurfaceTension;
        /* 0x0260 */ public float UnderwaterSurfaceOffset;
        /* 0x0264 */ public float UnderwaterSurfaceGravity;
        /* 0x0268 */ public float UnderwaterFlattenMinDepth;
        /* 0x026C */ public float UnderwaterFlattenRange;
        /* 0x0270 */ public float UnderwaterSurfaceForceFlatteningAngleMin;
        /* 0x0274 */ public float UnderwaterSurfaceForceFlatteningAngleRange;
        /* 0x0278 */ public float UnderwaterSurfaceSplashdownForce;
        /* 0x027C */ public float UnderwaterSurfaceSplashdownMinSpeed;
        /* 0x0280 */ public float UnderwaterJumpForce;
        /* 0x0284 */ public GcSpaceshipAvoidanceData UnderwaterAvoidance;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x02A8 */ public byte[] Padding2A8;
        [NMS(Size = 0x4)]
        /* 0x02B0 */ public Vector4f[] UnderwaterBubbleOffset;
		/* 0x2F0 */ public bool VehicleAltControlScheme;
		/* 0x2F4 */ public float VehicleAltControlStickSmoothInTime;
		/* 0x2F8 */ public float VehicleAltControlStickSmoothOutTime;
		/* 0x2FC */ public float VehicleBoostSpeedMultiplierPercent;
		/* 0x300 */ public float VehicleGarageHologramMinFadeRange;
		/* 0x304 */ public float VehicleGarageHologramFadeRange;
		/* 0x308 */ public float CheckpointPlacementOffset;
		/* 0x30C */ public float CheckpointPlacementRayLength;
		/* 0x310 */ public float CheckpointDeleteDistance;
		/* 0x314 */ public float CheckpointDeleteAngle;
		/* 0x318 */ public float BoostPadTime;
		/* 0x31C */ public float BoostPadStrength;
		/* 0x320 */ public float DisablePhysicsRange;
		/* 0x324 */ public float RaceMultipleStartOffset;
		/* 0x328 */ public float RaceMultipleStartCaptureRange;
		/* 0x32C */ public float MiningLaserDrainSpeed;
        /* 0x32C */ public float ProjectileDrainPerShot;
		/* 0x334 */ public float RaceStartSpawnUpOffset;
		/* 0x338 */ public float RaceInteractRespawnOffset;
		/* 0x33C */ public float RaceInteractRespawnUpOffset;
		/* 0x340 */ public float StickTurnReducer;
		/* 0x344 */ public float StickTurnReducerVR;
		/* 0x348 */ public float StickTurnReducerAlt;
		/* 0x34C */ public float TravelSpeedReportReducer;
		/* 0x350 */ public float HornScareRadius;
		/* 0x354 */ public float HornScareFleeRadius;
		/* 0x358 */ public float HornScareTime;
		/* 0x35C */ public float AttractAmount;
		/* 0x360 */ public float AttractMaxSpeed;
		/* 0x364 */ public float AttractAlign;
		/* 0x368 */ public float AttractDirectionBrakeThresholdSq;
		/* 0x36C */ public float ExitStopTime;
		/* 0x370 */ public float ExitStopForce;
		/* 0x374 */ public float GunFireRate;
		/* 0x378 */ public float SummoningRange;
		/* 0x37C */ public float CheckpointRadius;
		/* 0x380 */ public float RaceCooldown;
		/* 0x384 */ public float RaceResetFlashDuration;
		/* 0x388 */ public float RaceResetFlashIntensity;
		/* 0x38C */ public float CheckpointFlashDuration;
		/* 0x390 */ public float CheckpointFlashIntensity;
        /* 0x03A0 */ public Colour CheckpointBeamColourActive;
        /* 0x03B0 */ public Colour CheckpointBeamColourNormal;
        [NMS(Size = 0x1)]
        /* 0x03C0 */ public NMSString0x10[] DefaultBuggyLoadout;
        [NMS(Size = 0x2)]
        /* 0x03D0 */ public NMSString0x10[] DefaultBikeLoadout;
        [NMS(Size = 0x2)]
        /* 0x03F0 */ public NMSString0x10[] DefaultTruckLoadout;
        /* 0x0410 */ public float CheckpointBeamSizeNormal;
        /* 0x0414 */ public float CheckpointBeamSizeActive;
        /* 0x0418 */ public float CheckpointBeamOffset;
        /* 0x041C */ public float SpawnRotation;
        /* 0x0420 */ public float MechSpawnRotation;
        /* 0x0424 */ public float MiningLaserRadius;
        /* 0x0428 */ public int MiningLaserMiningDamage;
        /* 0x042C */ public int MiningLaserDamage;
        /* 0x0430 */ public float MiningLaserSpeed;
        /* 0x0434 */ public int GunBaseDamage;
        /* 0x0438 */ public int GunBaseMiningDamage;
        /* 0x043C */ public float ResourceCollectOffset;
        /* 0x0440 */ public float VehicleWheelNoise;
        /* 0x0444 */ public float VehicleWheelNoiseScale;
        /* 0x0448 */ public float WheelSideVerticalFactor;
        /* 0x044C */ public float SuspensionDamping;
        /* 0x0450 */ public float SuspensionDampingAngularFactor;
        /* 0x0454 */ public bool ShowTempVehicleMesh;
        /* 0x0455 */ public bool ShowVehicleDebugging;
        /* 0x0456 */ public bool ShowVehicleWheelGuards;
        /* 0x0457 */ public bool ShowVehicleText;
        /* 0x0458 */ public float VehicleTextSize;
        /* 0x045C */ public bool ShowVehicleParticleDebug;
        /* 0x045D */ public bool VehicleDrawAudioDebug;
        /* 0x0460 */ public float VehicleSuspensionAudioSpacing;
        /* 0x0464 */ public float VehicleSuspensionAudioDelay;
        /* 0x0468 */ public float VehicleSuspensionAudioScale;
        /* 0x046C */ public float VehicleSuspensionAudioTrigger;
        /* 0x0470 */ public float VehicleFadeTime;
        /* 0x0474 */ public float VehicleMinSummonDistance;
        /* 0x0478 */ public float VehicleMaxSummonDistance;
        /* 0x047C */ public float VehicleMaxSummonDistanceUnderwater;
        /* 0x0480 */ public float VehicleDeactivateRange;
        /* 0x0484 */ public float VehicleBoostFuelRate;
        /* 0x0488 */ public float VehicleBoostFuelRateSurvival;
        /* 0x048C */ public float VehicleFuelRate;
        /* 0x0490 */ public float VehicleFuelRateSurvival;
        /* 0x0494 */ public float VehicleFuelRateTruckMultiplier;
        /* 0x0498 */ public float VehicleJumpTimeMin;
        /* 0x049C */ public float VehicleJumpTimeMax;
        /* 0x04A0 */ public float VehicleJumpCooldown;
        /* 0x04A4 */ public float VehicleMotionDeadZone;
        /* 0x04A8 */ public float WheelForceHalflife;
        /* 0x04AC */ public bool ThrottleButtonCamRelative;
        /* 0x04B0 */ public float StickReverseTurnThreshold;
        /* 0x04B4 */ public float StickReverseTurnStiffness;
        /* 0x04B8 */ public GcScanData VehicleScan;
        /* 0x04CC */ public GcScanData VehicleLocalScan;
        [NMS(Size = 0x3)]
        /* 0x04E0 */ public GcMechDebugSpawnData[] DebugMechSpawns;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x06F0 */ public GcVehicleData[] VehicleDataTable;
    }
}
