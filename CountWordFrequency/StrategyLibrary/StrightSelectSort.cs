using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class StrightSelectSort : SortStrategy
    {
        public override void SortRun(List<Node> list)
        {
            for (int i = 0; i < list.Count; i++) 
            {
                int k = i;
                Node current = list[i];
                for (int j = i + 1; j < list.Count; j++) 
                {
                    if (list[j].Count > current.Count) 
                    {
                        current = list[j];
                        k = j;
                    }
                }
                if (k != i) 
                {
                    list[k] = list[i];
                    list[i] = current;
                }
            }
        }
    }
}
