﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CohesionAndCoupling.Interfaces
{
    public interface IRenderer
    {
        void WriteLine(string message, params object[] parameters);
    }
}
