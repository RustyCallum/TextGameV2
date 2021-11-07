using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Items
{
    interface IBackpackCreator
    {
        Backpack CreateBackpack();
    }
}
