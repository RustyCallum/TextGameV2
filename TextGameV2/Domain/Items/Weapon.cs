using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    public class Weapon : IItem
    {
        public string Name { get; set; }
        public int AttackDamage = 10;
        public int WeaponDurability = 100;
        //public string WeaponRarity;
    }
}
