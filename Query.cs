using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Query
    {
        public static void QueryDemo()
        {
            List<int> numbers = new List<int>()
        {
            10, 20, 30, 40, 50
        };

            var result = 
                from n in numbers
                where n > 20
                select n;  // Query syntax using LINQ and also Deferred execution

            numbers.Add(90);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}

