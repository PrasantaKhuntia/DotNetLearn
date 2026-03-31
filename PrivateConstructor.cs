using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class PrivateConstructor
    {
        private PrivateConstructor() {
            Console.WriteLine("Private Constructor is Called");
        }
    }
}
