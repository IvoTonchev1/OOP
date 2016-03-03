﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperRpgGame.Interfaces
{
    public interface ICharacter : IAttack, IDestroyable
    {
        string Name { get; }
        Position Position { get; }

    }
}
