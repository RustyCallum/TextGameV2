using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AttackDamage{ get; set; }
        public int Health { get; set; }
        public int Armour { get; set; }
        public bool IsHard { get; set; }
        public int MinReward { get; set; }
        public int MaxReward { get; set; }

        public int AmountOfReward;

        public int DamageTaken;

        public void TakeDamage()
        {
            Health -= DamageTaken;
        }

        public void GiveReward()
        {
            var rdnm = new Random();
            AmountOfReward = rdnm.Next(MinReward, MaxReward);
        }
    }
}
