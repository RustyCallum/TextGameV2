using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Items
{
    public class HealthPotion : IItem
    {
        public string Name { get; set; } = "Health Potion";

        int HealthToRecover = 10;

        public void Heal(Hero hero)
        {
            hero.DamageTaken -= HealthToRecover;
            hero.TakeDamage();
        }
    }
}
