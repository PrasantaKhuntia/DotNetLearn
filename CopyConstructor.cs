using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class CopyConstructor
    {
        public int num;
        public string name;

        public CopyConstructor(int Num, string Name)
        {
            num = Num;
            name = Name;
        }

        public CopyConstructor(CopyConstructor obj)
        {
            num = obj.num;
            name = obj.name;
        }
    }
}
