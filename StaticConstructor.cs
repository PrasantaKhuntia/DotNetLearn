using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class StaticConstructor
    {
        public static int num;
        static StaticConstructor() //Always called only once when we create the 1st object
        {
           num = 10;
           Console.WriteLine(num);
           Console.WriteLine("Static Constructor");
        }

        public StaticConstructor() 
        {
            Console.WriteLine("Default Constructor");
        }   
    }
}
