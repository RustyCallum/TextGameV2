using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    public class Armour : IItem
    {
        public string Name { get; set; }
        public int ArmourAmount = 8;
        public int ArmourDurability = 100;
        //public string ArmourRarity;
    }
}
