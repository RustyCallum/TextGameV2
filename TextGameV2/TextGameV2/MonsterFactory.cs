using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TextGameV2
{
    public static class MonsterFactory
    {
        private static readonly List<Monster> _monsters;

        static MonsterFactory()
        {
            var fileName = "C:/Users/Sylwia/Desktop/TextGameV2/TextGameV2/TextGameV2/Monsters.json.txt";
            var jsonString = File.ReadAllText(fileName);
            _monsters = JsonSerializer.Deserialize<List<Monster>>(jsonString);
        }

        public static Monster MonsterCreate()
        {
            var rd = new Random();
            var randomMonster = rd.Next(0, 7);

            return _monsters[randomMonster];
        }
    }
}
