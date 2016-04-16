using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class ShellInsertSort : SortStrategy
    {
        private void Shell (int delta, List<Node> list)
        {
            for (int i = delta; i < list.Count; i++) 
            {
                int j = i - delta;
                Node current = list[i];
                while (j >= 0 && list[j].Count < current.Count) 
                {
                    list[j + delta] = list[j];
                    j = j - delta;
                }
                list[j + delta] = current;
            }
        }
        public override void SortRun(List<Node> list)
        {
            for (int delta = list.Count / 2; delta > 0; delta /= 2) 
            {
                this.Shell(delta, list);
            }
        }
    }
}
