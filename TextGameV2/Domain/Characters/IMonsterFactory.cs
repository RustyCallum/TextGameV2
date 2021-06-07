using System;
using System.Collections.Generic;
using System.Text;

namespace TextGameV2.Domain.Characters
{
    interface IMonsterFactory
    {
        Monster MonsterCreate();
    }
}
