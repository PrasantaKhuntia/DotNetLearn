using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class AnonymousMethod
    {
        public static int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public void Calculation()
        {         

            //Func<int,int,int> add = Add;

            //Func<int, int, int> add = delegate (int num1, int num2) {
            //    return (num1 + num2);                
            //};

            //Lambda Expression

            //Func<int,int,int> add = (num1, num2) => (num1 + num2); //Multi parameters

             Func<int, int> multiplication = (x) => x * x; //Single parameter

            //Action<int, int> add = (num1, num2) => Console.Write(num1 + num2);

            //Predicate<int> add = (x) => x % 2 == 0;

            //int result = add(6,5);

            int result = multiplication(5);

            Console.WriteLine(result);
        }
    }
}
