using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class Encapsulation
    {
        private int num = 5;

        public int Num
        {
            get { return num; }
            set
            {
                if (value >= 0 && value <= 100){

                   num = value;
                   Console.WriteLine(num);
                }
                else
                    Console.WriteLine("Invalid Value");
            }
        }
    }
}
