using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class BubbleExchangeSort : SortStrategy
    {
        public override void SortRun(List<Node> list)
        {
            bool flag = false;
            int len = list.Count;
            for (int i = 0; i < len - 1; i++) 
            {
                for (int j = len - 1; j > i; j--) 
                {
                    if (list[j].Count > list[j - 1].Count) 
                    {
                        Node temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    break;
                }
            }
        }
    }
}
