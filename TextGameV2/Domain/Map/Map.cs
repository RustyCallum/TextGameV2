using System;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public class Map
    {
        private readonly ILocation[,] _map;
        private readonly Hero _hero;
        private readonly int _sizeX = 11;
        private readonly int _sizeY = 11;
        private int _currentX = 5;
        private int _currentY = 5;

        public Map(Hero hero)
        {
            _map = new ILocation[_sizeX, _sizeY];
            _map[_currentX, _currentY] = LocationFactory.CreateLocation();
            _hero = hero;
        }

        public void Go(Direction direction)
        {
            switch (direction)
            {
                case Direction.North:
                    ChangeCoordinates(_currentX, _currentY + 1);
                    break;
                case Direction.South:
                    ChangeCoordinates(_currentX, _currentY - 1);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}");
            };
        }

        private void ChangeCoordinates(int x, int y)
        {
            if (!CanMoveToLocation(x, y))
            {
                Console.WriteLine("Can't move there");
                return;
            };
            _map[_currentX, _currentY].LeavingHero();
            _currentX = x;
            _currentY = y;

            if (_map[_currentX, _currentY] == null)
            {
                _map[_currentX, _currentY] = LocationFactory.CreateLocation();
            }
            _map[_currentX, _currentY].EnterHero(_hero);
        }

        private bool CanMoveToLocation(int x, int y)
        {
            if(y == _sizeY || y < 0 || x == _sizeX || x < 0)
            {
                return false;
            }

            return true;
        }
    }
}
