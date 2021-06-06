using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2
{
    class Backpacks : IItem
    {
        public string Name { get; set; }
        public int Space { get; set; } = 6;

        public List<IItem> ListOfItems;

        public Backpacks()
        {
            ListOfItems = new List<IItem>();
            ListOfItems.Capacity = Space;
        }

        public void AddItem(IItem item)
        {
            if (ListOfItems.Count < Space)
            { 
                ListOfItems.Add(item);
            }
            else if (ListOfItems.Count >= Space)
            {
                Console.WriteLine("You don't have enough space");
            }
        }
    }
}
