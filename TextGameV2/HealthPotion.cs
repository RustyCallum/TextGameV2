using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    class HealthPotion : IItem
    {
        public string Name { get; set; } = "Health Potion";

        int HealthToRecover = 10;

        public void Heal()
        {
            MainPuzzle.HeroObj.DamageTaken -= HealthToRecover;
            MainPuzzle.HeroObj.TakeDamage();
        }
    }
}
