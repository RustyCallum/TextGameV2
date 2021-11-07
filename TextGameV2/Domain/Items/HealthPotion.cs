using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Items
{
    public class HealthPotion : IItem
    {
        public string Name { get; set; } = "Health Potion";

        private int _healthToRecover = 10;

        //Determinates price
        public int MinPrice { get; set; } = 30;
        public int MaxPrice { get; set; } = 40;
        public int FinalPrice { get; set; }

        public HealthPotion()
        {
            SetCost();
        }

        public void Heal(Hero hero)
        {
            hero.DamageTaken -= _healthToRecover;
            hero.TakeDamage();
        }

        public void SetCost()
        {
            var rdnm = new Random();
            FinalPrice = rdnm.Next(MinPrice, MaxPrice);
        }
    }
}
