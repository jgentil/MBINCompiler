﻿using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x5348, GUID = 0x5512A3254E8EA381, NameHash = 0x2A28407EECDFA4CC)]
    public class GcRealityIconTable : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0000 */ public TkTextureResource[] HazardIcons;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0318 */ public TkTextureResource[] HazardIconsHUD;
        [NMS(Size = 0x9, EnumType = typeof(GcRealitySubstanceCategory.SubstanceCategoryEnum))]
        /* 0x0630 */ public TkTextureResource[] SubstanceCategoryIcons;
        [NMS(Size = 0x9, EnumType = typeof(GcProductCategory.ProductCategoryEnum))]
        /* 0x0AD4 */ public TkTextureResource[] ProductCategoryIcons;
        [NMS(Size = 0x8, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x0F78 */ public TkTextureResource[] MissionFactionIcons;
        [NMS(Size = 0x11, EnumType = typeof(GcDiscoveryTypes.DiscoveryTypeEnum))]
        /* 0x1398 */ public TkTextureResource[] BinocularDiscoveryIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x1C5C */ public TkTextureResource[] DiscoveryPageTradingIcons;
        [NMS(Size = 0x3, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x1FF8 */ public TkTextureResource[] DiscoveryPageConflictIcons;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x2184 */ public TkTextureResource[] DiscoveryPageRaceIcons;
        /* 0x25A4 */ public TkTextureResource DiscoveryPageTradingUnknown;
        /* 0x2628 */ public TkTextureResource DiscoveryPageConflictUnknown;
        /* 0x26AC */ public TkTextureResource DiscoveryPageRaceUnknown;
        /* 0x2730 */ public List<GcPlanetResourceIconLookup> TerrainIconLookups;
        /* 0x2740 */ public List<GcPlanetResourceIconLookup> PlanetResourceIconLookups;
        /* 0x2750 */ public List<TkTextureResource> RepairTechIcons;
        [NMS(Size = 0x55, EnumType = typeof(GcRealityGameIcons.GameIconsEnum))]
        /* 0x2760 */ public TkTextureResource[] GameIcons;
        /* 0x5338 */ public List<GcRealityIcon> MissionDetailIcons;
    }
}
