using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyLibrary
{
    public class WordFrequency : Context
    {
        // 循环字符串数组生成List
        public List<Node> burnList(string str, string[] patterns) 
        {
            if (patterns.Length == 0) 
            {
                throw new Exception("字典文件为空");
            }
            int len = patterns.Length;
            List<Node> list = new List<Node>(len);
            int i = 0;
            while (i < len) 
            {
                list.Add(this.matchRun(str, patterns[i++]));
            }
            return list;
        }
        // 利用List进行排序,写入生成文件
        public void burnResult(List<Node> list) 
        {
            this.sortRun(list);
        }
    }
}
