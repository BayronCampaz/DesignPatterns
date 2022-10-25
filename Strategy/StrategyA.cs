﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class StrategyA : IStrategy
    {
        public object Execute(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }
}
