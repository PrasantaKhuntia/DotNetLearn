using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class ConstructorOverloading
    {
        int n1, n2, n3;
        public ConstructorOverloading(int num1, int num2)
        {
            n1 = num1;
            n2 = num2;
        }

        public ConstructorOverloading(int num1, int num2, int num3)
        {
            n1 = num1;
            n2 = num2;
            n3 = num3;
        }
    }
}
