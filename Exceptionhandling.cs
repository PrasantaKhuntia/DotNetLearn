using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class Exceptionhandling
    {
        int[] nums = new int[3];

        public void Calculation()
        {
            try {
                int a = 10;
                int b = 0;
                int c = a / b;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.WriteLine("You can go and check the error and fix it");
            }
            
        }        
    }
}
