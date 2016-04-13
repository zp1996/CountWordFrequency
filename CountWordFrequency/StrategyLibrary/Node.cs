using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class Node
    {
        private string key;
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }
        private int count;
        public int Count
        {
            get { return this.count; }
            set { this.count = value; }
        }
        public Node(string key, int count) 
        {
            this.key = key;
            this.count = count;
        }
    }
}
