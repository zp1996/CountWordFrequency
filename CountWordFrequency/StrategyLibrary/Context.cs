using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Configuration;

namespace StrategyLibrary
{
    public class Context
    {
        private readonly string namespaceName = "StrategyLibrary";
        private readonly string _sortName = ConfigurationManager.AppSettings["MatchName"];
        private readonly string _matchName = ConfigurationManager.AppSettings["SortName"];
        
        private string _sortClassName;
        private string _matchClassName;

        private SortStrategy sort;
        private MatchStrategy match;

        public Context() 
        {
            this._sortClassName = this.namespaceName + "." + _sortName;
            this._matchClassName = this.namespaceName + "." + _matchName;
            this.match = Assembly.Load(this.namespaceName).CreateInstance(this._sortClassName) as MatchStrategy;
            this.sort = Assembly.Load(this.namespaceName).CreateInstance(this._matchClassName) as SortStrategy;        
        }

        public Node matchRun(string str, string pattern) 
        {
            return this.match.MatchRun(str, pattern);        
        }

        public void sortRun(List<Node> list) 
        {
            this.sort.SortRun(list);
        }
    }
}
