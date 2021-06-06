using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Actions;

namespace TextGameV2.Domain
{
    public class Location : ILocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RequireHard { get; set; }
        public bool CanYouMine { get; set; }
        public bool CanLoot { get; set; }

        public void EnterHero(Hero hero)
        {
            Console.WriteLine($"Hero {hero.Name} entering {Name}");

            var rdNum = new Random();
            var willWeFight = rdNum.Next(0, 100);
            if (willWeFight < 30)
            {
                FightAction.Fight(hero, MonsterFactory.MonsterCreate());
            }
        }

        public void LeavingHero()
        {
            Console.WriteLine($"I am leaving {Name}");
        }
    }
}
