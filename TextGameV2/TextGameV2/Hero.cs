using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    public class Hero
    {
        public string Name { get; set; }

        private int _health = 100;
        private int _money = 50;

        public int DamageTaken;

        public dynamic armour;
        public dynamic weapon;
        public dynamic backpack;

        public void TakeDamage()
        {
            _health -= DamageTaken;
        }
        public void DisplayHealth()
        {
            Console.WriteLine("You have " + _health + " health!");
        }
        public void GetReward()
        {
            _money += Fighting.MonsterObj.AmountOfReward;
        }
    }
}
