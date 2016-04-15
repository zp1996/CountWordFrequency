using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class KMPMatch : MatchStrategy
    {
        private int[] burnNext(string pattern) 
        {
            int[] next = new int[pattern.Length];
            next[0] = -1;
            int j = -1, i = 0;
            while (i < pattern.Length - 1) 
            {
                if (j == -1 || pattern[i] == pattern[j])
                {
                    i++;
                    j++;
                    if (pattern[i] == pattern[j])
                    {
                        next[i] = next[j];
                    }
                    else
                    {
                        next[i] = j;
                    }
                }
                else 
                {
                    j = next[j];
                }
            }
            return next;
        }
        public override Node MatchRun(string str, string pattern)
        {
            int[] next = this.burnNext(pattern);
            int i = 0;
            int j = 0; 
            int count = 0;
            while (i < str.Length - 1) 
            {
                if (j == -1 || str[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
                if (j == pattern.Length)
                {
                    count++;
                    j = 0;
                }
            }
            Node result = new Node(pattern, count);
            return result;
        }
    }
}
