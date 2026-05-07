using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class CancelTokenImpl
    {
        public async Task DoSomeWork( CancellationToken token) {

            for (int i=1; i<10; i++) {

                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Cancellation requested. Stopping work.");
                    return;
                }
                else { 
                
                    await Task.Delay(1000);
                    Console.WriteLine(i);
                }
            
            }
        }
    }
}
