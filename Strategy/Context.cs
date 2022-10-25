using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Context
    {
        private IStrategy _strategy;

        public Context()
        {

        }
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteBusinessLogic()
        {
            Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            var result = this._strategy.Execute(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
