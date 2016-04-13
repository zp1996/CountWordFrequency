using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public abstract class SortStrategy
    {
        abstract public void SortRun(List<Node> list);
    }
}
