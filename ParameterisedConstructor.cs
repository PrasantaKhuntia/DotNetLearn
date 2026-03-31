using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class ParameterisedConstructor
    {
        public int num;
        public string name;

        public ParameterisedConstructor(int Num, string Name)
        {
            num = Num;
            name = Name;
        }
    }
}
