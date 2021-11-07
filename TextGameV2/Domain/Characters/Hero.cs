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
        public int Money { get; private set; } = 50;

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
            Money += monster.AmountOfReward;
        }

        public void ShowEquipment()
        {
            Console.WriteLine($"You have {Weapon.Name} in your weapon slot and {Armour.Name} in your armour slot");
        }

        public void DrinkInTavern()
        {
            Money -= 80;
            _health += 10;
        }
    }
}
