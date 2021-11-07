using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    public class Backpack : IItem
    {
        //Determinates price
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public int FinalPrice { get; set; }

        public string Name { get; set; }
        public int Space { get; set; }

        public List<IItem> Items;

        public Backpack()
        {
            Items = new List<IItem>();
            Items.Capacity = Space;
        }

        public void AddItem(IItem item)
        {
            if (Items.Count < Space)
            { 
                Items.Add(item);
            }
            else if (Items.Count >= Space)
            {
                Console.WriteLine("You don't have enough space");
            }
        }

        public void ListItems()
        {
            foreach(var item in Items)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
