using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Items;

namespace TextGameV2.Actions
{
    public class Trade : ITrade
    {
        private List<IItem> _tradeList;

        public Trade()
        {
            _tradeList = new List<IItem>();
        }
        public void RollItemsForSell()
        {
            var i = 0;
            while(i <= 10) 
            { 
                _tradeList.Add(new HealthPotion());
                i++;
            }
        }

        public void ShowSale()
        {
            RollItemsForSell();
            foreach(var item in _tradeList)
            {
                Console.WriteLine($"{item.Name} is here for {item.FinalPrice}");
            }
        }
    }
}
