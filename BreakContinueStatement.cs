using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class BreakContinueStatement
    {
        int[] arr = new int[5];

        public void StoreData()
        {
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 30)
                {
                    //break;//exit the loop
                    continue;// skip the current iteration
                }
                else
                {
                    Console.WriteLine("Value is" + arr[i]);
                }
            }
        }
    }
}
