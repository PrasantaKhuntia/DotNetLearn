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

        //Singlecast, Multicast, Generic delegates
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

        //Generic Delegate = Func, Action, Predicate
        //Func = Accepts one or more input parameters and returns a value
        //Action = Accepts one or more input parameters and does not return a value
        //Predicate = Accepts one input parameter and returns a boolean value

        public void Calculation()
        {
            //Func<int,int,int> Add = (num1, num2) => (num1 + num2);

            //Action<int, int> Add = (num1, num2) => Console.Write(num1 + num2);

            Predicate<int> Add = (x) => x%2==0;

            bool result = Add(6);

            Console.WriteLine(result);

        }
            
    }  
    
    
}
