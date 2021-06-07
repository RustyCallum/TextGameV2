using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public class City : ICity
    {
        private readonly Hero _hero;
        private string _nameofcity = "Novigrad"; 

        public City(Hero hero)
        {
            _hero = hero;
        }
        public void InsideCity(Hero hero)
        {
            while (true)
            {
                Console.WriteLine($"You are now inside a city of {_nameofcity} {hero.Name}, what do you want to do?");
                Console.WriteLine("h = go to public house, t = go to tavern, e = exit");
                string PlayerActionInCity = Console.ReadLine();
                if (PlayerActionInCity == "h")
                {
                    Console.WriteLine("This action require a lot of money, which you dont have");
                }
                else if (PlayerActionInCity == "t")
                {
                    Console.WriteLine("You are entering the tavern");
                    InsideTavern(hero);

                }
                else if (PlayerActionInCity == "e")
                {
                    break;
                }
            }
        }

        public void InsideTavern(Hero hero)
        {
            while (true)
            {
                Console.WriteLine($"You are now in the tavern, {hero.Name}, what are you planning to do?");
                Console.WriteLine("d = get a drink, s = trade with shopkeeper, e = exit");
                string PlayerActionInTavern = Console.ReadLine();
                if (PlayerActionInTavern == "d")
                {
                    if (hero.Money >= 80)
                    {
                        hero.DrinkInTavern();
                        Console.WriteLine("You rested while drinking at the tavern and restored 10 health");
                    }
                    else if (hero.Money <= 80)
                    {
                        Console.WriteLine("You don't have enough money to buy a drink");
                    }
                }
                else if (PlayerActionInTavern == "e")
                {
                    return;
                }
            }
        }
    }
}
