using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    public class Weapon : IItem
    {
        public int MinPrice { get; set; } = 40;
        public int MaxPrice { get; set; } = 50;

        public int FinalPrice { get; set; }
        public string Name { get; set; }
        public int AttackDamage = 10;
        public int WeaponDurability = 100;
        //public string WeaponRarity;

        public void SharpenWeapon()
        {
            AttackDamage += 5;
        }
    }
}
