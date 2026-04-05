using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class LearnDelegate
    {
        //Type safe method pointer
        public delegate int myDelegate(int num1, int num2);

        public static int Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
            return (num1 + num2);
        }

        public static int Sub(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
            return (num1 - num2);
        }
    }

    //Singlecast, Multicast, Generic delegates
}
