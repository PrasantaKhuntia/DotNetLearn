using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal abstract class Vehicle
    {
        int num;
        public abstract void start();

        public Vehicle() { }

        public void add()
        {
            Console.WriteLine("");
        }
    }

    internal class Car : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("car will start with a key");
        }
    }

    internal class Bike : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("bike will start with a kick");
        }
    }
}
