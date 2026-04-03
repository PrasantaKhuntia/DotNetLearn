using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal static class ClassVariations
    {
        public static int num;

        public static void Add()
        {
            Console.WriteLine("This is a static method.");
        }
    }

    internal sealed class SealedClass
    {
        public void Display()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }

    //internal class childClass : SealedClass
    //{
    //    // This will cause a compile-time error because SealedClass is sealed and cannot be inherited.
    //}

    internal abstract class Vehicle1
    {
        int num;
        public abstract void start();

        public Vehicle1() { }

        public void add()
        {
            Console.WriteLine("");
        }
    }

    internal partial class Employee
    {
        public void Display()
        {
            Console.WriteLine("This is a partial class.");
        }
    }

    internal partial class Employee
    {
        public void Display1()
        {
            Console.WriteLine("This is a partial class.");
        }
    }


}
