using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    public class ClassA
    {
        public void displayA()
        {
            Console.WriteLine("This is Class A");
        }
    }

    public class ClassB: ClassA
    {
        public void displayB()
        {
            Console.WriteLine("This is Class B");
        }
    }

    public class ClassC : ClassA
    {
        public void displayC()
        {
            Console.WriteLine("This is Class C");
        }
    }
}
