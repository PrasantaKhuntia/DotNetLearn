using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class LearnGenerics<T>
    {
        public void Add<T>(T num1)
        {
            Console.WriteLine(num1);
        }
    }
}
