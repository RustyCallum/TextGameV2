using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    public class Armour : IItem
    {
        //Determinates price
        public int MinPrice { get; set; } = 30;
        public int MaxPrice { get; set; } = 40;
        public int FinalPrice { get; set; }

        public string Name { get; set; }
        public int ArmourAmount = 8;
        public int ArmourDurability = 100;
        //public string ArmourRarity;
    }
}
