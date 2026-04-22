using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class ExceptionThrow
    {
        public void A() {
            try {

                B();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void B() {
            try {

                C();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void C() { 
        
            int a = 10;
            int b = 0;
            int c = a / b;
        }
    }
}
