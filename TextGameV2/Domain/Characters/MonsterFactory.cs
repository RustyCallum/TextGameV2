using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TextGameV2.Domain.Characters
{
    public class MonsterFactory : IMonsterFactory
    {
        private readonly List<Monster> _monsters;

        public MonsterFactory()
        {
            var fileName = "Configs/Monsters.json.txt";
            var jsonString = File.ReadAllText(fileName);
            _monsters = JsonSerializer.Deserialize<List<Monster>>(jsonString);
        }

        public Monster MonsterCreate()
        {
            var rd = new Random();
            var randomMonster = rd.Next(0, 7);

            return _monsters[randomMonster];
        }
    }
}
