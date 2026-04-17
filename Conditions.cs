using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class Conditions
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
                    Console.WriteLine("Value is 30" );
                }
                else
                {
                   Console.WriteLine("Value is not 30");
                }
            }

            //Switch-case statement
        }
    }
}
