using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StrategyLibrary;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaab";
            string pattern = "aaaab";
            Context test = new Context();
            Node x = test.matchRun(str, pattern);
            Console.WriteLine("{0}, {1}", x.Count, x.Key);

            List<Node> list = new List<Node>();
            Node zp = new Node("周鹏11", 26);
            Node zp2 = new Node("周鹏11", 23);
            Node zp3 = new Node("周鹏11", 25);
            Node zp4 = new Node("周鹏11", 20);
            list.Add(zp);
            list.Add(zp2);
            list.Add(zp3);
            list.Add(zp4);
            test.sortRun(list);
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine("{0}, {1}", list[i].Count, list[i].Key);
            }
            //SortStrategy sort = new BubbleExchangeSort(list);
            //sort.SortRun();
        }
    }
}
