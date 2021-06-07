using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Actions;
using TextGameV2.Domain.Items;

namespace TextGameV2.Domain.Characters
{
    public class Hero
    {
        public string Name { get; set; }

        private int _health = 100;
        private int _money = 50;

        public int DamageTaken;

        public Armour Armour;
        public Weapon Weapon;
        public Backpack Backpack;

        public void TakeDamage()
        {
            _health -= DamageTaken;
        }
        public void DisplayHealth()
        {
            Console.WriteLine("You have " + _health + " health!");
        }
        public void GetReward(Monster monster)
        {
            _money += monster.AmountOfReward;
        }
    }
}
