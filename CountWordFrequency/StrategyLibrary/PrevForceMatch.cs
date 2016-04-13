using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class PrevForceMatch : MatchStrategy
    {
        public override Node MatchRun(string str, string pattern)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++) 
            {
                if (str[i] == pattern[0]) 
                {
                    int j = 1;
                    for (; j < pattern.Length; j++) 
                    {
                        if (str[i + j] != pattern[j]) 
                        {
                            break;
                        }
                    }
                    if (j == pattern.Length) 
                    {
                        count++;
                    }
                }
            }
            Node result = new Node(pattern, count);
            return result;
        }
    }
}
