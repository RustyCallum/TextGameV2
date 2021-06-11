using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public class City : ICity
    {
        private string _nameofcity = "Novigrad";
        private readonly IBuilding _tavern;

        public City()
        {
            _tavern = new Tavern();
        }
        public void EnterCity(Hero hero)
        {
            Console.WriteLine($"You are now inside a city of {_nameofcity} {hero.Name}, what do you want to do?");
            while (true)
            {
                Console.WriteLine("h = go to public house, t = go to tavern, e = exit");
                string PlayerActionInCity = Console.ReadLine();
                if (PlayerActionInCity == "h")
                {
                    Console.WriteLine("This action require a lot of money, which you dont have");
                }
                else if (PlayerActionInCity == "t")
                {
                    Console.WriteLine("You are entering the tavern");
                    _tavern.Enter(hero);

                }
                else if (PlayerActionInCity == "e")
                {
                    break;
                }
            }
        }
    }
}
