using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Actions;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public class Location : ILocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RequireHard { get; set; }
        public bool CanYouMine { get; set; }
        public bool CanLoot { get; set; }

        private readonly IMonsterFactory _monsterFactory;
        private readonly IFightAction _fightAction;

        public Location()
        {
            _fightAction = new FightAction();
            _monsterFactory = new MonsterFactory();
        }
        public void EnterHero(Hero hero)
        {
            Console.WriteLine($"Hero {hero.Name} entering {Name}");
            var rdNum = new Random();
            var willWeFight = rdNum.Next(0, 100);
            if (willWeFight < 30)
            {
                _fightAction.Fight(hero, _monsterFactory.MonsterCreate());
            }
        }
        public void LeavingHero()
        {
            Console.WriteLine($"I am leaving {Name}");
        }
    }
}
