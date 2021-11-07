using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    public interface IItem
    {
        string Name { get; set; }

        int MinPrice { get; set; }
        int MaxPrice { get; set; }
        int FinalPrice { get; set; }
    }
}
