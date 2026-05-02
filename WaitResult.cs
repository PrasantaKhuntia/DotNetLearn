using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class WaitResult
    {
        public async Task DoTimeConsumingWork()
        {
            Console.WriteLine("Starting time-consuming work...");
            await Task.Delay(3000); 
            Console.WriteLine("Finished time-consuming work.");
        }
    }
}
