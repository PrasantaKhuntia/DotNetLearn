using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class MethodOverloadingPolymorphism
    {
        // method overloading - diffrent types of parameters
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }

        public void Add(string name1, string name2)
        {
            Console.WriteLine(name1);
            Console.WriteLine(name2);
        }
    }
}
