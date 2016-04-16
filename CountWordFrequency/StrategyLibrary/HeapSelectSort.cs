using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class HeapSelectSort : SortStrategy
    {
        private void Restore(Node[] Key, int j, int vCount) 
        {
            while (j <= vCount / 2) 
            {
                int m = (2 * j + 1 < vCount && Key[2 * j + 1].Count < Key[2 * j].Count ? 2 * j + 1 : 2 * j);
                if (Key[m].Count < Key[j].Count)
                {
                    Node temp = Key[m];
                    Key[m] = Key[j];
                    Key[j] = temp;
                    j = m;
                }
                else 
                {
                    break;
                }
            }
        }
        public override void SortRun(List<Node> list)
        {
            int vCount = list.Count;
            Node[] tempKey = new Node[vCount + 1];
            for (int i = 0; i < vCount; i++) 
            {
                tempKey[i + 1] = list[i];
            }
            for (int i = vCount / 2; i > 0; i--) 
            {
                this.Restore(tempKey, i, vCount);
            }
            for (int i = vCount; i > 1; i--) 
            {
                Node temp = tempKey[i];
                tempKey[i] = tempKey[1];
                tempKey[1] = temp;
                this.Restore(tempKey, 1, i - 1);
            }
            for (int i = 0; i < vCount; i++) 
            {
                list[i] = tempKey[i + 1];
            }
        }
    }
}
