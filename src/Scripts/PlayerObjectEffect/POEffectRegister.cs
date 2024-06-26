﻿using static DataPearl.AbstractDataPearl;
using static Pearlcat.POEffect;
using DataPearlTypeMSC = MoreSlugcats.MoreSlugcatsEnums.DataPearlType;

namespace Pearlcat;

public static partial class POEffectManager
{
    public static POEffect None;
    public static POEffect Color;



    // Custom
    public static POEffect AS_PearlBlue;
    public static POEffect AS_PearlGreen;
    public static POEffect AS_PearlRed;
    public static POEffect AS_PearlYellow;
    public static POEffect AS_PearlBlack;

    public static POEffect RM;
    public static POEffect SS;

    public static POEffect MI;

    public static POEffect CW;



    // Vanilla & MSC
    public static POEffect Misc;
    public static POEffect SL_moon;
    public static POEffect SL_chimney;
    public static POEffect SL_bridge;
    public static POEffect SB_filtration;
    public static POEffect SB_ravine;
    public static POEffect SU;
    public static POEffect HI;
    public static POEffect GW;
    public static POEffect DS;
    public static POEffect SH;
    public static POEffect CC;
    public static POEffect UW;
    public static POEffect LF_bottom;
    public static POEffect LF_west;

    public static POEffect SI_top;
    public static POEffect SI_west;

    public static POEffect VS;
    public static POEffect SU_filt;
    public static POEffect OE;
    public static POEffect LC;
    public static POEffect LC_second;
    public static POEffect MS;
    public static POEffect DM;

    public static POEffect SI_chat3;
    public static POEffect SI_chat4;
    public static POEffect SI_chat5;

    public static POEffect Red_stomach;
    public static POEffect Rivulet_stomach;
    public static POEffect Spearmasterpearl;

    public static POEffect IteratorWhite;
    public static POEffect IteratorBlack;
    public static POEffect IteratorOrange;
    public static POEffect IteratorBlue;



    public static void RegisterEffects()
    {
        PearlEffects.Clear();
        CustomPearlEffects.Clear();

        SetEffects();



        PearlEffects.Add(DataPearlType.Misc, Misc);
        PearlEffects.Add(DataPearlType.Misc2, Misc);

        PearlEffects.Add(DataPearlType.SL_moon, SL_moon);
        PearlEffects.Add(DataPearlType.SL_chimney, SL_chimney);
        PearlEffects.Add(DataPearlType.SL_bridge, SL_bridge);
        PearlEffects.Add(DataPearlType.SB_filtration, SB_filtration);
        PearlEffects.Add(DataPearlType.SB_ravine, SB_ravine);
        PearlEffects.Add(DataPearlType.SU, SU);
        PearlEffects.Add(DataPearlType.HI, HI);
        PearlEffects.Add(DataPearlType.GW, GW);
        PearlEffects.Add(DataPearlType.DS, DS);
        PearlEffects.Add(DataPearlType.SH, SH);
        PearlEffects.Add(DataPearlType.CC, CC);
        PearlEffects.Add(DataPearlType.UW, UW);
        PearlEffects.Add(DataPearlType.LF_bottom, LF_bottom);
        PearlEffects.Add(DataPearlType.LF_west, LF_west);

        PearlEffects.Add(DataPearlType.SI_top, SI_top);
        PearlEffects.Add(DataPearlType.SI_west, SI_west);

        PearlEffects.Add(DataPearlType.Red_stomach, Red_stomach);

        if (ModManager.MSC)
        {
            PearlEffects.Add(DataPearlTypeMSC.BroadcastMisc, Misc);

            PearlEffects.Add(DataPearlTypeMSC.VS, VS);
            PearlEffects.Add(DataPearlTypeMSC.SU_filt, SU_filt);
            PearlEffects.Add(DataPearlTypeMSC.OE, OE);
            PearlEffects.Add(DataPearlTypeMSC.LC, LC);
            PearlEffects.Add(DataPearlTypeMSC.LC_second, LC_second);
            PearlEffects.Add(DataPearlTypeMSC.MS, MS);
            PearlEffects.Add(DataPearlTypeMSC.DM, DM);

            PearlEffects.Add(DataPearlTypeMSC.Rivulet_stomach, Rivulet_stomach);
            PearlEffects.Add(DataPearlTypeMSC.Spearmasterpearl, Spearmasterpearl);

            PearlEffects.Add(DataPearlTypeMSC.SI_chat3, SI_chat3);
            PearlEffects.Add(DataPearlTypeMSC.SI_chat4, SI_chat4);
            PearlEffects.Add(DataPearlTypeMSC.SI_chat5, SI_chat5);

            PearlEffects.Add(DataPearlTypeMSC.CL, RM);
            PearlEffects.Add(DataPearlTypeMSC.RM, RM);
        }



        PearlEffects.Add(Enums.Pearls.RM_Pearlcat, RM);
        PearlEffects.Add(Enums.Pearls.SS_Pearlcat, SS);
        PearlEffects.Add(Enums.Pearls.Heart_Pearlpup, MI);

        PearlEffects.Add(Enums.Pearls.AS_PearlBlue, AS_PearlBlue);
        PearlEffects.Add(Enums.Pearls.AS_PearlRed, AS_PearlRed);
        PearlEffects.Add(Enums.Pearls.AS_PearlGreen, AS_PearlGreen);
        PearlEffects.Add(Enums.Pearls.AS_PearlYellow, AS_PearlYellow);
        PearlEffects.Add(Enums.Pearls.AS_PearlBlack, AS_PearlBlack);

        PearlEffects.Add(Enums.Pearls.CW_Pearlcat, CW);
    }

    public static void SetEffects()
    {
        None = new();

        Misc = None;
        Misc.ThrowingSkill = 0.5f;
        Misc.MajorEffect = MajorEffectType.SPEAR_CREATION;
        Misc.ActiveMultiplier = 2.0f;
        Misc.LungsFac = -0.05f;
        Misc.RunSpeedFac = 0.05f;
        Misc.PoleClimbSpeedFac = 0.05f;
        Misc.CorridorClimbSpeedFac = 0.05f;

        IteratorWhite = Misc;

        IteratorBlack = Misc;
        IteratorBlack.MajorEffect = MajorEffectType.CAMOFLAGUE;



        Color = None;
        
        SL_moon = Color;
        SL_moon.MajorEffect = MajorEffectType.SHIELD;
        SL_moon.ThreatMusic = "SL";

        SL_chimney = Color;
        SL_chimney.MajorEffect = MajorEffectType.RAGE;
        SL_chimney.ThreatMusic = "SL";

        SL_bridge = Color;
        SL_bridge.MajorEffect = MajorEffectType.RAGE;
        SL_bridge.ThreatMusic = "SL";

        SB_filtration = Color;
        SB_filtration.MajorEffect = MajorEffectType.AGILITY;
        SB_filtration.ThreatMusic = "SB";

        SB_ravine = Color;
        SB_ravine.MajorEffect = MajorEffectType.CAMOFLAGUE;
        SB_ravine.ThreatMusic = "SB";

        SU = Color;
        SU.MajorEffect = MajorEffectType.AGILITY;
        SU.ThreatMusic = "SU";

        HI = Color;
        HI.MajorEffect = MajorEffectType.AGILITY;
        HI.ThreatMusic = "HI";

        GW = Color;
        GW.MajorEffect = MajorEffectType.REVIVE;
        GW.ThreatMusic = "GW";

        DS = Color;
        DS.MajorEffect = MajorEffectType.REVIVE;
        DS.ThreatMusic = "DS";

        SH = Color;
        SH.MajorEffect = MajorEffectType.RAGE;
        SH.ThreatMusic = "SH";

        CC = Color;
        CC.MajorEffect = MajorEffectType.SHIELD;
        CC.ThreatMusic = "CC";

        UW = Color;
        UW.MajorEffect = MajorEffectType.REVIVE;
        UW.ThreatMusic = "UW";

        LF_bottom = Color;
        LF_bottom.MajorEffect = MajorEffectType.RAGE;
        LF_bottom.ThreatMusic = "LF";

        LF_west = Color;
        LF_west.MajorEffect = MajorEffectType.RAGE;
        LF_west.ThreatMusic = "LF";

        SI_west = Color;
        SI_west.MajorEffect = MajorEffectType.AGILITY;
        SI_west.ThreatMusic = "SI";

        SI_top = Color;
        SI_top.MajorEffect = MajorEffectType.CAMOFLAGUE;
        SI_top.ThreatMusic = "SI";

        
        // MSC
        VS = Color;
        VS.MajorEffect = MajorEffectType.RAGE;
        VS.ThreatMusic = "VS";

        SU_filt = Color;
        SU_filt.MajorEffect = MajorEffectType.RAGE;
        SU_filt.ThreatMusic = "SU";

        OE = Color;
        OE.MajorEffect = MajorEffectType.RAGE;
        OE.ThreatMusic = "OE";

        LC = Color;
        LC.MajorEffect = MajorEffectType.REVIVE;
        LC.ThreatMusic = "LC";

        LC_second = Color;
        LC_second.MajorEffect = MajorEffectType.RAGE;
        LC_second.ThreatMusic = "LC";

        MS = Color;
        MS.MajorEffect = MajorEffectType.SHIELD;
        MS.ThreatMusic = "MS";

        DM = Color;
        DM.MajorEffect = MajorEffectType.SHIELD;
        DM.ThreatMusic = "DM";

        SI_chat3 = Color;
        SI_chat3.MajorEffect = MajorEffectType.RAGE;
        SI_chat3.ThreatMusic = "SI";

        SI_chat4 = Color;
        SI_chat4.MajorEffect = MajorEffectType.REVIVE;
        SI_chat4.ThreatMusic = "SI";

        SI_chat5 = Color;
        SI_chat5.MajorEffect = MajorEffectType.RAGE;
        SI_chat5.ThreatMusic = "SI";


        // Special
        Red_stomach = Color;
        Red_stomach.MajorEffect = MajorEffectType.RAGE;

        Rivulet_stomach = Color;
        Rivulet_stomach.MajorEffect = MajorEffectType.AGILITY;

        Spearmasterpearl = Color;
        Spearmasterpearl.MajorEffect = MajorEffectType.RAGE;

        IteratorOrange = Color;
        IteratorOrange.LungsFac = 0.05f;
        IteratorOrange.RunSpeedFac = -0.05f;
        IteratorOrange.PoleClimbSpeedFac = -0.05f;
        IteratorOrange.CorridorClimbSpeedFac = -0.05f;
        IteratorOrange.MajorEffect = MajorEffectType.SHIELD;

        IteratorBlue = Color;
        IteratorBlue.LungsFac = 0.05f;
        IteratorBlue.RunSpeedFac = -0.05f;
        IteratorBlue.PoleClimbSpeedFac = -0.05f;
        IteratorBlue.CorridorClimbSpeedFac = -0.05f;
        IteratorBlue.MajorEffect = MajorEffectType.AGILITY;



        // Custom
        AS_PearlBlue = Color;
        AS_PearlBlue.MajorEffect = MajorEffectType.AGILITY;

        AS_PearlGreen = Color;
        AS_PearlGreen.MajorEffect = MajorEffectType.REVIVE;

        AS_PearlRed = Color;
        AS_PearlRed.MajorEffect = MajorEffectType.RAGE;

        AS_PearlYellow = Color;
        AS_PearlYellow.MajorEffect = MajorEffectType.SHIELD;

        AS_PearlBlack = Misc;
        AS_PearlBlack.MajorEffect = MajorEffectType.CAMOFLAGUE;

        RM = None;
        RM.MajorEffect = MajorEffectType.NONE;
        RM.ActiveMultiplier = 2.0f;
        RM.LungsFac = -0.15f;
        RM.RunSpeedFac = 0.15f;
        RM.PoleClimbSpeedFac = 0.15f;
        RM.CorridorClimbSpeedFac = 0.15f;
        RM.RollSpeedFac = 0.15f;
        RM.SlideSpeedFac = 0.15f;

        SS = None;
        SS.MajorEffect = MajorEffectType.NONE;
        SS.ActiveMultiplier = 2.0f;
        SS.LungsFac = -0.3f;
        SS.RunSpeedFac = 0.3f;
        SS.PoleClimbSpeedFac = 0.3f;
        SS.CorridorClimbSpeedFac = 0.3f;
        SS.RollSpeedFac = 0.3f;
        SS.SlideSpeedFac = 0.3f;

        MI = None;
        MI.MajorEffect = MajorEffectType.NONE;
        MI.ActiveMultiplier = 2.0f;
        MI.LungsFac = -0.3f;
        MI.RunSpeedFac = 0.3f;
        MI.PoleClimbSpeedFac = 0.3f;
        MI.CorridorClimbSpeedFac = 0.3f;
        MI.RollSpeedFac = 0.3f;
        MI.SlideSpeedFac = 0.3f;

        CW = None;
        CW.MajorEffect = MajorEffectType.AGILITY;
        CW.ActiveMultiplier = 3.0f;
        CW.LungsFac = -0.3f;
        CW.RunSpeedFac = 0.3f;
        CW.PoleClimbSpeedFac = 0.3f;
        CW.CorridorClimbSpeedFac = 0.3f;
        CW.RollSpeedFac = 0.3f;
        CW.SlideSpeedFac = 0.3f;
    }
}
