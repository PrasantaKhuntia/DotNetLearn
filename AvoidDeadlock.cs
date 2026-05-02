using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class AvoidDeadlock
    {
        object lock1 = new object();
        object lock2 = new object();

        //public void Method1()
        //{
        //    lock (lock1)
        //    {
        //        Console.WriteLine("Method1: Acquired lock1");
        //        Thread.Sleep(1000); // Simulating some work

        //        lock (lock2)
        //        {
        //            Console.WriteLine("Method1: Acquired lock2");
        //        }
        //    }
        //}

        //public void Method2()
        //{
        //    lock (lock1)
        //    {
        //        Console.WriteLine("Method2: Acquired lock2");
        //        Thread.Sleep(1000); // Simulating some work

        //        lock (lock2)
        //        {
        //            Console.WriteLine("Method2: Acquired lock1");
        //        }
        //    }
        //}

        public void Method1()
        {
            if(Monitor.TryEnter(lock1, 5000))
            {
                try
                {
                    Console.WriteLine("Method1: Acquired lock1");
                    Thread.Sleep(1000); // Simulating some work
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Method1: Exception - " + ex.Message);
                }
                finally
                {
                    Monitor.Exit(lock1);
                }
            }
            else
            {
                Console.WriteLine("Method1: Could not acquire lock1");
            }
        }

    }
}
