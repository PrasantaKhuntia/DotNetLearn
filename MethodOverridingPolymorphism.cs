using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class MethodOverridingPolymorphism
    {
        public virtual void display()
        {
            Console.WriteLine("Base class method");
        }
    }

    internal class MethodOverridingPolymorphismChild: MethodOverridingPolymorphism
    {
        public override void display()
        {
            Console.WriteLine("Child class method");
        }
    }
}
