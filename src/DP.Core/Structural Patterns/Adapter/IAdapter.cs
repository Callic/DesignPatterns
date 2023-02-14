﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Core.Structural_Patterns.Adapter
{
    public interface IAdapter<T> where T : class
    {
        void Executar();
    }
}
