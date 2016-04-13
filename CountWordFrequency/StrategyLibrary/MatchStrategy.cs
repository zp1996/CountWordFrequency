using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public abstract class MatchStrategy
    {
        public abstract Node MatchRun(string str, string pattern);
    }
}
