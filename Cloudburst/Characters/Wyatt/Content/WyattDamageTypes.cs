﻿using R2API;

namespace Cloudburst.Characters.Wyatt
{
    public class WyattDamageTypes
    {
        public static DamageAPI.ModdedDamageType antiGravDamage;
        public static DamageAPI.ModdedDamageType antiGravDamage2;
        public static DamageAPI.ModdedDamageType applyGroove;

        public static void InitDamageTypes()
        {
            antiGravDamage = DamageAPI.ReserveDamageType();
            antiGravDamage2 = DamageAPI.ReserveDamageType();
            applyGroove = DamageAPI.ReserveDamageType();
        }
    }
}