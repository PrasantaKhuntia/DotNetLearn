using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class MethodHiding
    {
        public void display()
        {
            Console.WriteLine("Base class method");
        }
    }

    internal class MethodHidingChild : MethodHiding
    {
        public new void display()
        {
            Console.WriteLine("Child class method");
        }
    }
}
