﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x19F0, GUID = 0x54BD186BA7992F70, NameHash = 0xB032629C37506E6A)]
    public class GcFleetGlobals : NMSTemplate
    {
        /* 0x0000 */ public Vector3f FreighterCustomiserSunAngleAdjust;
        /* 0x0010 */ public NMSString0x20A CivilianMPMissionGiverPuzzle;
        /* 0x0030 */ public float MaxPurchaseDistance;
        /* 0x0034 */ public float SingleShipFlybyDistance;
        /* 0x0038 */ public float SingleShipFlybyMaxAngle;
        /* 0x003C */ public float SingleShipFlybyHeightOffset;
        /* 0x0040 */ public float DistanceForFlybyCommsReset;
        /* 0x0044 */ public float DistanceForPurchaseReset;
        /* 0x0048 */ public float CombatFrigateSpawnMinRange;
        /* 0x004C */ public float CombatFrigateSpawnAngle;
        /* 0x0050 */ public float CombatNotificationTime;
        /* 0x0054 */ public float CombatDefenderSpawnDelay;
        /* 0x0058 */ public float PostCombatSpawnDelay;
        /* 0x005C */ public float CombatSpawnDelay;
        /* 0x0060 */ public List<float> CombatSpawnDelayIncreaseByInventoryClass;
        /* 0x0070 */ public int ExplorationPointsRequiredForScan;
        /* 0x0074 */ public GcInteractionDof FleetInteractionDepthOfField;
        /* 0x0088 */ public int PercentChangeOfFrigateBeingPurchasable;
        /* 0x0090 */ public NMSString0x20A FleetCommunicationOSDMessage;
        /* 0x00B0 */ public int MinFrigateStatValue;
        /* 0x00B4 */ public int MaxFrigateStatValue;
        /* 0x00B8 */ public float MinFrigateDistanceFromFreighter;
        /* 0x00BC */ public float MaxFrigateDistanceFromFreighter;
        /* 0x00C0 */ public float FrigateDistanceMultiplierIfNoCaptialShip;
        /* 0x00C4 */ public int PercentChanceOfFrigateAdditionalSpawnedTrait;
        /* 0x00C8 */ public int MaximumSpeedDecrease;
        /* 0x00CC */ public int MaximumSpeedIncrease;
        /* 0x00D0 */ public float CameraPauseAfterStartingExpedition;
        /* 0x00D4 */ public float UITraitLinesAngle;
        /* 0x00D8 */ public List<GcFrigateUITraitLines> UITraitLineLengths;
        /* 0x00E8 */ public List<NMSString0x20> RacialTermForCaptain;
        /* 0x00F8 */ public float TimeBeforeShowingHangar;
        /* 0x00FC */ public float TimeBeforeHidingHangar;
        /* 0x0100 */ public int NumberOfShipsInInitialFleet;
        /* 0x0104 */ public bool NewFrigatesStartDamaged;
        /* 0x0105 */ public bool ExpeditionsCompleteInstantly;
        /* 0x0106 */ public bool ShowSeeds;
        /* 0x0107 */ public bool DisablePlayerFleets;
        /* 0x0108 */ public NMSString0x20A DebugInterventionEvent;
        // size: 0x9
        public enum ForceDebriefEntryTypeEnum { None, PrimarySuccess, PrimaryFailure, PrimaryDamage, SecondarySuccess, SecondaryFailure,
            SecondaryDamage, GenericSuccess, GenericFailure
        }
        /* 0x0128 */ public ForceDebriefEntryTypeEnum ForceDebriefEntryType;
        /* 0x012C */ public int ForcedSequentialEventsStartingIndex;
        /* 0x0130 */ public int NextDebriefDescriptionOffset;
        /* 0x0134 */ public float LevelupProgressRequiredToNotBeSadAboutDamage;
        /* 0x0138 */ public float TimeBeforePlayerAlertedToDamagedFrigates;
        /* 0x013C */ public float DamagedListEntryPulseRate;
        /* 0x0140 */ public float NonUrgentDamagedListEntryAlpha;
        /* 0x0144 */ public int LowDamageNumberOfExpeditions;
        /* 0x0148 */ public int RampDamageNumberOfExpeditions;
        /* 0x014C */ public Vector2f PercentChanceOfDamageOnFailedEvent;
        /* 0x0154 */ public int PercentChanceOfGenericEventDescription;
        /* 0x0158 */ public int PercentChanceOfPrimaryDescriptionForBalancedEvent;
        /* 0x015C */ public GcNumberedTextList FrigateDamageDescriptions;
        /* 0x0180 */ public GcNumberedTextList FrigateGoodMoods;
        /* 0x01A4 */ public GcNumberedTextList FrigateBadMoods;
        /* 0x01C8 */ public GcNumberedTextList FrigateExtraNotes;
        /* 0x01EC */ public float RadiusRequiredForFrigateSpawn;
        /* 0x01F0 */ public float SpawnDelayForNewFrigates;
        /* 0x01F4 */ public float SpawnDelayForFleetFrigates;
        /* 0x01F8 */ public float SpawnDelayForReturningFrigates;
        /* 0x01FC */ public float SpawnDelayRandomMin;
        /* 0x0200 */ public float SpawnDelayRandomMax;
        /* 0x0204 */ public float SpawnDelayIncreasePerFrigate;
        /* 0x0208 */ public float DespawnDelay;
        /* 0x020C */ public float DespawnDelayIncreasePerFrigate;
        /* 0x0210 */ public float FrigatesPerSecondForInstantSpawn;
        /* 0x0214 */ public float HologramSwapSpeed;
        /* 0x0218 */ public NMSString0x20A TerminalNeedsAssignmentPuzzleID;
        /* 0x0238 */ public NMSString0x20A TerminalInterventionPuzzleID;
        /* 0x0258 */ public NMSString0x20A TerminalDamagePuzzleID;
        /* 0x0278 */ public NMSString0x20A TerminalActivePuzzleID;
        /* 0x0298 */ public NMSString0x20A TerminalDebriefPuzzleID;
        /* 0x02B8 */ public NMSString0x20A NormandyActivePuzzleID;
        /* 0x02D8 */ public NMSString0x20A NormandyDebriefPuzzleID;
        /* 0x02F8 */ public NMSString0x20A DeepSpaceFrigateActivePuzzleID;
        /* 0x0318 */ public NMSString0x20A DeepSpaceFrigateDebriefPuzzleID;
        /* 0x0338 */ public NMSString0x20A NeedFrigatesPuzzleID;
        /* 0x0358 */ public NMSString0x20A NewExpeditionsAvailablePuzzleID;
        /* 0x0378 */ public NMSString0x20A NeedExpeditionTerminalPuzzleID;
        /* 0x0398 */ public NMSString0x20A NeedAvailableExpeditionTerminalPuzzleID;
        /* 0x03B8 */ public NMSString0x20A SelectExpeditionPuzzleID;
        /* 0x03D8 */ public int NumberOfExpeditionChoices;
        /* 0x03DC */ public int ExpeditionDifficultyVariance;
        /* 0x03E0 */ public float ExpeditionDifficultyIncreaseForEachAdditionalFrigate;
        /* 0x03E4 */ public int MinExpeditionStatValue;
        /* 0x03E8 */ public int MaxExpeditionStatValue;
        /* 0x03EC */ public int NumberOfFrigatesPurchasedToEndEasyExpeditions;
        /* 0x03F0 */ public int TimeTakenForExpeditionEvent_Easy;
        /* 0x03F4 */ public int TimeTakenForExpeditionEvent;
        /* 0x03F8 */ public int LightYearsPerExpeditionEvent_Easy;
        /* 0x03FC */ public int LightYearsPerExpeditionEvent;
        /* 0x0400 */ public int NumberOfUAChangesPerExpeditionEvent;
        /* 0x0404 */ public int TimeBetweenPassiveIncomeTicks;
        /* 0x0408 */ public List<GcExpeditionPaymentToken> FreighterTokenProductIDs;
        /* 0x0418 */ public GcPassiveFrigateIncomeArray PassiveIncomes;
        /* 0x04F8 */ public List<GcExpeditionPowerup> Powerups;
        /* 0x0508 */ public int FreighterTokenMinimumSpend;
        /* 0x050C */ public int PercentChanceOfInterventionEvent;
        /* 0x0510 */ public int FirstEventIndexWhichCanBeIntervention;
        /* 0x0514 */ public float TimeBeforePlayerAlertedToInterventionEvent;
        /* 0x0518 */ public int MaxDiceRollWhenCalculatingExpeditionEventResult;
        /* 0x051C */ public float DifficultyMultiplierForBalancedExpeditions;
        /* 0x0520 */ public float DifficultyMultiplierForNonPrimaryEvents;
        /* 0x0524 */ public int StatPointsAwardedForLevelUp;
        /* 0x0528 */ public int MinGapBetweenExpeditionLogEntries;
        /* 0x052C */ public int MaxGapBetweenExpeditionLogEntries;
        /* 0x0530 */ public float TimeBetweenDebriefLettersAppearing;
        /* 0x0534 */ public float TimeBetweenDebriefLogSectionsAppearing;
        /* 0x0538 */ public float TimeBetweenDebriefLogsAppearing;
        /* 0x053C */ public float TimeBeforeDebriefLogsStart;
        /* 0x0540 */ public bool ShowMissingRewardDescriptions;
        /* 0x0548 */ public NMSString0x20A CommunicatorDamagePuzzleTableEntry;
        /* 0x0568 */ public NMSString0x20A FrigateDamagePuzzleTableEntry;
        /* 0x0588 */ public NMSString0x20A FrigatePurchasePuzzleTableEntry;
        /* 0x05A8 */ public List<int> DifficultyModifier;
        /* 0x05B8 */ public List<GcExpeditionDebriefPunctuation> DebriefPunctuationList;
        /* 0x05C8 */ public GcExpeditionDurationValues ExpeditionDurations;
        /* 0x05DC */ public GcFrigateClassCost FrigateBaseCost;
        /* 0x05F8 */ public GcFrigateClassCost FrigateCostVariance;
        /* 0x0614 */ public GcInventoryClassCostMultiplier FrigateCostMultiplier;
        /* 0x0628 */ public GcFrigateTraitStrengthByType FrigateTraitStrengths;
        /* 0x0998 */ public GcFrigateStatsByClass FrigateInitialStats;
        /* 0x0C70 */ public GcFrigateTraitIcons TraitIcons;
        /* 0x11F0 */ public GcFrigateTraitIcons NegativeTraitIcons;
        /* 0x1770 */ public GcScanEffectData FrigateScanEffect;
        /* 0x17C0 */ public GcScanEffectData FrigateHologramScanEffect;
        /* 0x1810 */ public GcScanEffectData CompletedFrigateHologramScanEffect;
        /* 0x1860 */ public GcScanEffectData DamagedFrigateHologramScanEffect;
        /* 0x18B0 */ public GcScanEffectData DestroyedFrigateHologramScanEffect;
        /* 0x1900 */ public GcExpeditionEventOccurrenceRate EventTypeOccurrenceChance;
        /* 0x1968 */ public List<NMSString0x80> FrigateHologramModels;
        /* 0x1978 */ public List<NMSString0x80> FrigatePlanetModels;
        /* 0x1988 */ public List<int> ExpeditionRankBoundaries;
        /* 0x1998 */ public List<int> FrigateLevelVictoriesRequired;
        /* 0x19A8 */ public List<GcExpeditionDifficultyKeyframe> ExpeditionDifficultyKeyframes;
        /* 0x19B8 */ public List<NMSString0x80> FrigateInteriorsToCache;
        /* 0x19C8 */ public int NormandyFailures;
        /* 0x19CC */ public int NormandyDamageEvents;
        /* 0x19D0 */ public List<NMSString0x10> NormandyTraits;
        /* 0x19E0 */ public List<NMSString0x10> DeepSpaceFrigateTraits;
    }
}
