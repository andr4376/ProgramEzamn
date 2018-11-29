using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_og_designpatterns
{
    class StrategyClient
    {
        public IStrategy strategy;

        public StrategyClient(IStrategy _strat)
        {
            strategy = _strat;
        }

        public void Execute()
        {
            strategy.Execute();
        }
    }
}
