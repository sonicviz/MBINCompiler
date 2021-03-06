﻿using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcTechnology : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x000 */ public string ID; // 0x10

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x010 */ public string Name; // 0x80

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x80)]
        /* 0x090 */ public string NameLower; // 0x80

        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        /* 0x130 */ public bool Teach;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x7)]
        [NMSAttribute(Ignore = true)]
        /* 0x131 */ public byte[] Padding131;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        /* 0x138 */ public string HintStart;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x20)]
        /* 0x158 */ public string HintEnd;

        /* 0x178 */ public TkTextureResource Icon;

        /* 0x200 */ public Colour Colour;
        /* 0x210 */ public int Level;
        /* 0x214 */ public bool Chargeable;
        /* 0x218 */ public int ChargeAmount;

        /* 0x21C */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x220 */ public List<NMSString0x10> ChargeBy;
        /* 0x230 */ public bool BuildFullyCharged;
        /* 0x231 */ public bool Upgrade;
        /* 0x232 */ public bool Core;
        /* 0x234 */ public GcTechnologyCategory TechnologyCategory;

        /* 0x238 */ public GcTechnologyRarity TechnologyRarity;

        /* 0x23C */ public float Value;
        /* 0x240 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x250 */ public List<GcStatsBonus> StatBonuses;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x260 */ public string RequiredTech;

        /* 0x270 */ public float RequiredLevel; // todo: is this correct?

        /* 0x280 */ public Colour UpgradeColour;
        /* 0x290 */ public Colour LinkColour;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        /* 0x2A0 */ public string RewardGroup;
    }
}
