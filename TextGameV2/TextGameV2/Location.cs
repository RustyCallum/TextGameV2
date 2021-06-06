using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool RequireHard { get; set; }
        public bool CanYouMine { get; set; }
        public bool CanLoot { get; set; }
    }
}
