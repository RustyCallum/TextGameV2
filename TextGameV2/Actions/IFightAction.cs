using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Actions
{
    interface IFightAction
    {
        void Fight(Hero hero, Monster monster);
    }
}
