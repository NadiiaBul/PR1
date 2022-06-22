using System;
using System.Collections.Generic;

namespace LinqToObjects
{
    class PrintOnScreen
    {
        public void WriteOnScreen<T>(IEnumerable<T> query)
        {
            foreach (var x in query)
            {
                Console.WriteLine(x.ToString());
            }
        }
        public void PrintCondition(string condition)
        {
            Console.WriteLine(condition);
        }
        public void WriteOnScreen<T, M>(Dictionary<T, List<M>> query)
        {
            foreach(var x in query)
            {
                Console.WriteLine(x.Key);
                Console.WriteLine($"Кількість: {x.Value.Count}");
                foreach (var y in x.Value)
                {
                    Console.WriteLine(y.ToString());
                }
            }
        }
    }
}
