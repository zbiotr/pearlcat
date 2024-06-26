﻿using MoreSlugcats;
using System.Linq;
using UnityEngine;

namespace Pearlcat;

public static partial class Hooks
{
    public static void ApplyPearlpupHooks()
    {
        On.Weapon.HitThisObject += Weapon_HitThisObject;

        On.Player.ctor += Player_ctorPearlpup;
        On.Player.Update += Player_UpdatePearlpup;

        On.Player.CanIPickThisUp += Player_CanIPickThisUp;

        On.Player.Update += Player_Update_PearlpupIDCheck;
    }

    // Ensure that any pup with Pearlpup's ID is automatically converted for edge cases
    private static void Player_Update_PearlpupIDCheck(On.Player.orig_Update orig, Player self, bool eu)
    {
        orig(self, eu);

        var miscWorld = self.abstractCreature.world.game.GetMiscWorld();

        if (miscWorld == null) return;

        if (self.abstractCreature.ID.number == miscWorld.PearlpupID && !self.IsPearlpup())
        {
            self.abstractCreature.MakePearlpup();
        }
    }

    // Stop pearlpup stealing pearls moon is reading
    private static bool Player_CanIPickThisUp(On.Player.orig_CanIPickThisUp orig, Player self, PhysicalObject obj)
    {
        var result = orig(self, obj);

        if (self.IsPearlpup())
        {
            if (self.room?.updateList?.FirstOrDefault(x => x is Oracle) is Oracle oracle && oracle.oracleBehavior is SLOracleBehavior behavior)
            {
                if (obj == behavior.holdingObject)
                {
                    return false;
                }
            }
        }

        return result;
    }

    // Make next slugpup a pearlpup if respawn is enabled
    private static void Player_ctorPearlpup(On.Player.orig_ctor orig, Player self, AbstractCreature abstractCreature, World world)
    {
        orig(self, abstractCreature, world);

        if (!ModOptions.PearlpupRespawn.Value) return;

        if (self.SlugCatClass != MoreSlugcatsEnums.SlugcatStatsName.Slugpup) return;

        var save = world.game.GetMiscWorld();

        if (!world.game.IsStorySession || save?.PearlpupID != null) return;

        self.abstractCreature.MakePearlpup();
    }

    private static void Player_UpdatePearlpup(On.Player.orig_Update orig, Player self, bool eu)
    {
        orig(self, eu);

        if (!self.TryGetPearlpupModule(out var module)) return;

        var stats = self.slugcatStats;
        var miscProg = Utils.GetMiscProgression();
        

        if (self.Malnourished || miscProg.IsPearlpupSick)
        {
            stats.throwingSkill = 0;
            stats.runspeedFac = 0.9f;
            stats.corridorClimbSpeedFac = 0.9f;
            stats.poleClimbSpeedFac = 0.9f;
            stats.lungsFac = 0.1f;
        }
        else
        {
            stats.throwingSkill = 2;
            stats.runspeedFac = self.grabbedBy.Count > 0 ? 0.9f : 1.1f;
            stats.corridorClimbSpeedFac = 1.1f;
            stats.poleClimbSpeedFac = 1.15f;
            stats.lungsFac = 0.1f;
        }

        if (miscProg.IsPearlpupSick)
        {
            //stats.foodToHibernate = stats.maxFood;

            self.redsIllness ??= new(self, 10);
            self.redsIllness.Update();
        }   

        stats.generalVisibilityBonus = 0.1f;
        stats.visualStealthInSneakMode = 0.3f;
        stats.loudnessFac = 1.35f;

        if (self.abstractCreature.Room.world.game.devToolsActive && Input.GetKey("q"))
        {
            self.AddFood(1);
        }

        if (module.TextureUpdateTimer > self.TexUpdateInterval())
        {
            if ((module.LastBodyColor != module.BodyColor || module.LastAccentColor != module.AccentColor))
            {
                module.LoadTailTexture("pearlpup_tail");
                module.LoadEarLTexture("ear_l");
                module.LoadEarRTexture("ear_r");
            }

            module.LastBodyColor = module.BodyColor;
            module.LastAccentColor = module.AccentColor;

            module.TextureUpdateTimer = 0;
        }
        else
        {
            module.TextureUpdateTimer++;
        }
    }

    // Prevent players from attacking pearlpup
    private static bool Weapon_HitThisObject(On.Weapon.orig_HitThisObject orig, Weapon self, PhysicalObject obj)
    {
        var result = orig(self, obj);

        bool hitPlayerByPlayer = obj is Player && self is Spear && self.thrownBy != null && self.thrownBy is Player;

        if (hitPlayerByPlayer && obj is Player player && player.IsPearlpup())
            return false;

        return result;
    }
}
