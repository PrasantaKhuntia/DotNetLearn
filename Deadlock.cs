using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class Deadlock
    {
        object lock1 = new object();
        object lock2 = new object();

        public void Method1()
        {
            lock (lock1)
            {
                Console.WriteLine("Method1: Acquired lock1");
                Thread.Sleep(1000); // Simulating some work

                lock (lock2)
                {
                    Console.WriteLine("Method1: Acquired lock2");
                }
            }
        }

        public void Method2()
        {
            lock (lock2)
            {
                Console.WriteLine("Method2: Acquired lock2");
                Thread.Sleep(1000); // Simulating some work

                lock (lock1)
                {
                    Console.WriteLine("Method2: Acquired lock1");
                }
            }
        }
    }
}
