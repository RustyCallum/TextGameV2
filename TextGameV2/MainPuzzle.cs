using System;
using TextGameV2.Domain;
using TextGameV2.Domain.Characters;
using TextGameV2.Domain.Items;
using TextGameV2.Domain.Map;

namespace TextGameV2
{
    class MainPuzzle
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name?:");
            string heroName = Console.ReadLine();

            var weapon = new Weapon();
            var armour = new Armour();

            armour.Name = "Basic armour";
            weapon.Name = "Basic weapon";

            var hero = new Hero
            {
                Name = heroName,
                Armour = armour,
                Weapon = weapon,
                Backpack = new Backpack()
            };

            var healthPotion = new HealthPotion();
            hero.Backpack.AddItem(healthPotion);

            Console.WriteLine("Hello " + hero.Name);
            Console.WriteLine("You wield " + hero.Weapon.Name + " and you have " + hero.Armour.Name + " on yourself.");

            var map = new Map(hero);

            while (true)
            {
                Console.WriteLine("Where do you want to go " + hero.Name);
                string WayChoice = Console.ReadLine();
                if (WayChoice == "n")
                {
                    map.Go(Direction.North);
                }
                else if (WayChoice == "s")
                {
                    map.Go(Direction.South);
                }
                else if (WayChoice == "w")
                {
                    map.Go(Direction.West);
                }
                else if (WayChoice == "e")
                {
                    map.Go(Direction.East);
                }
            }
        }
    }
}
