using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    class Log : IItem
    {
        public int MinPrice { get; set; } = 30;
        public int MaxPrice { get; set; } = 40;

        public int FinalPrice { get; set; }
        public string Name { get; set; } = "Log";
    }
}
