using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class TaskExplain
    {

        public async Task  DoTimeConsumingWork()
        {
            Console.WriteLine("Starting time-consuming work...");
            // Simulate time-consuming work
             await Task.Delay(3000); // non blocking delay for 3 seconds
            Console.WriteLine("Finished time-consuming work.");
        }
    }
}
