using System;
using System.Collections.Generic;
using System.Text;
using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    interface ICity
    {
        void EnterCity(Hero hero);
    }
}
