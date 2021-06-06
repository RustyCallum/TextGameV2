using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    class Map
    {
        public Location[,] _map { get; set; }
        int currX = 5;
        int currY = 5;
        public Map() 
        {
            _map = new Location[11,11];
            _map[currX, currY] = LocationFactory.CreateLocation();
        }

        public void GoNorth()
        {
            LeavingHero();
            currY += 1;
            if (_map[currX, currY] == null)
            {
                _map[currX, currY] = LocationFactory.CreateLocation();
                var rdNum = new Random();
                var WillWeFight = rdNum.Next(0, 100);
                if (WillWeFight < 30)
                {
                    Fighting.FightingCode();
                }
            }
            EnterHero();
        }
        public void GoSouth()
        {
            LeavingHero();
            currY -= 1;
            if (_map[currX, currY] == null)
            {
                _map[currX, currY] = LocationFactory.CreateLocation();
                var rdNum = new Random();
                var WillWeFight = rdNum.Next(0, 100);
                if (WillWeFight < 30)
                {
                    Fighting.FightingCode();
                }
            }
            EnterHero();
        }
        public void GoEast()
        {
            currX += 1;
            if (_map[currX, currY] == null)
            {
                var rdNum = new Random();
                var WillWeFight = rdNum.Next(0, 100);
                if (WillWeFight < 30)
                {
                    Fighting.FightingCode();
                }
                _map[currX, currY] = LocationFactory.CreateLocation();
            }
            Console.WriteLine(_map[currX, currY].Name);
        }
        public void GoWest()
        {
            LeavingHero();
            currX -= 1;
            if (_map[currX, currY] == null)
            {
                _map[currX, currY] = LocationFactory.CreateLocation();
            }
            EnterHero();
        }
        public void EnterHero()
        {
            Console.WriteLine("I am entering " + _map[currX, currY].Name);
        }
        public void LeavingHero()
        {
            Console.WriteLine("I am leaving " + _map[currX, currY].Name);
        }

        public void RollFight()
        {
            
        }
    }
}
