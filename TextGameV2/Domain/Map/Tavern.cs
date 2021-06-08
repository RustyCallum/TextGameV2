using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public class Tavern : IBuilding
    {
        private readonly Hero _hero;

        public Tavern(Hero hero)
        {
            _hero = hero;
        }

        public void Enter(Hero hero)
        {
            Console.WriteLine($"You are now in the tavern, {hero.Name}, what are you planning to do?");
            while (true)
            {
                Console.WriteLine("d = get a drink, s = trade with shopkeeper, e = exit");
                string playerActionInTavern = Console.ReadLine();

                switch (playerActionInTavern)
                {
                    case "d":
                        Drink(hero);
                        break;

                    case "s":
                        TradeWithTavernkeeper(_hero);
                        break;

                    case "e":
                        return;

                }
            }
        }

        public void Drink(Hero hero)
        {
            if (hero.Money <= 80)
            {
                Console.WriteLine("You don't have enough money to buy a drink");
                return;
            }
            _hero.DrinkInTavern();
            Console.WriteLine("You rested while drinking at the tavern and restored 10 health");
        }

        public void TradeWithTavernkeeper(Hero hero)
        {
            return;
        }
    }
}
