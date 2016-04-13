using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class StraightInsertSort : SortStrategy
    {
        public override void SortRun(List<Node> list) 
        {
            int len = list.Count;
            int j = 0;
            Node current = null;
            for (int i = 1; i < len; i++) 
            {
                j = i - 1;
                current = list[i];
                while (j >= 0 && list[j].Count < current.Count) 
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = current;
            }
        }
    }
}
