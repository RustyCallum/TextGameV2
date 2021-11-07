using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace TextGameV2.Domain.Items
{
    public class BackpackCreator : IBackpackCreator
    {
        private readonly List<Backpack> _backpacks;
        public BackpackCreator()
        {
            var fileName = "Configs/Backpacks.json.txt";
            var jsonString = File.ReadAllText(fileName);
            _backpacks = JsonSerializer.Deserialize<List<Backpack>>(jsonString);
        }
        public Backpack CreateBackpack()
        {
            var rd = new Random();
            var randomBackpack = rd.Next(0, 2);

            return _backpacks[randomBackpack];
        }

    }
}
