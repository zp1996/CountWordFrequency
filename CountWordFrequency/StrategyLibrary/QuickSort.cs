using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class QuickSort : SortStrategy
    {
        private void QuickSortFun (List<Node> list, int left, int right) 
        {
            if (left < right)
            {
                Node current = list[left];
                int i = left;
                int j = right;
                while (i < j)
                {
                    while (list[j].Count < current.Count && i < j) 
                    {
                        j--;
                    }
                    while (list[i].Count >= current.Count && i < j) 
                    {
                        i++;
                    }
                    if (i < j) 
                    {
                        Node temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                list[left] = list[j];
                list[j] = current;
                if (left < j - 1) this.QuickSortFun(list, left, j - 1);
                if (right > j + 1) this.QuickSortFun(list, j + 1, right);
            }
        }

        public override void SortRun(List<Node> list)
        {
            this.QuickSortFun(list, 0, list.Count - 1);
        }
    }
}
