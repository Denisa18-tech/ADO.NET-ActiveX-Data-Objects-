using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemo
{
    internal class Method
    {
    
        public static void MethodDemo()
        {
            List<int> numbers = new List<int>()
        {
            10, 20, 30, 40, 50
        };

            var result = numbers.Where(n => n > 10).ToList(); // Method syntax using lambda expression and also Immediate execution with ToList()

            numbers.Add(90); 

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
