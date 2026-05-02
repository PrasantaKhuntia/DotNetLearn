using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace DotNetLearn
{
    internal class ConcurrDict
    {
        public void Method1() { 
        
            //Dictionary<int, string> dict = new Dictionary<int, string>();

            ConcurrentDictionary<int, string> dict = new ConcurrentDictionary<int, string>();

            //Adding values to the dictionary
            //for (int i = 0; i < 10; i++)
            //{
            //    dict.TryAdd(i, "Value" + i);
            //}

            Parallel.For(0, 10, i =>
            {
                dict.TryAdd(i, "Value" + i);
            });

            //Reading values from the dictionary
            foreach (var i in dict)
            {
                Console.WriteLine($"Key: {i.Key}, Value: {i.Value}");
            }
        }
    }
}
