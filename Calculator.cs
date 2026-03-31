using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    public class Calculator
    {
        protected int num1 = 5;

        public void sum(int num1, int num2)
        {
            this.num1 = 10;
            Console.WriteLine(num1 + num2);
        }
    }
}
