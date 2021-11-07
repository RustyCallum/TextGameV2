using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public class Blacksmith : IBuilding
    {
        public void Enter(Hero hero)
        {
            Console.WriteLine("You ahve entered a blacksmiths work station, what do you want to do here?");
            Console.WriteLine("u = Upgrade, t = Trade with blacksmith, e = Exit");
            Console.Write("What are you going to do?: ");
            string action = Console.ReadLine();

            switch (action)
            {
                case "u":
                    UpgradeEquipment(hero);
                    break;

                case "t":
                    break;

                case "e":
                    return;
            }
        }
        public void UpgradeEquipment(Hero hero)
        {
            Console.Write("Which piece of equipment you wish to upgrade? ");
            string WhichToUpgrade = Console.ReadLine();
            switch (WhichToUpgrade)
            {
                case "weapon":
                    if (hero.Money < 50)
                    {
                        Console.WriteLine("Blacksmith: I see you don't have enough money lad. I'm sorry. ");
                        return;
                    }
                    hero.Weapon.SharpenWeapon();
                    Console.WriteLine("Blacksmith: Here you go lad, your weapon has been sharpened. ");
                    break;
            }
        }
    }
}
