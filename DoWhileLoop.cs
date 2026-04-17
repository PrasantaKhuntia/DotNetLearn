using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class DoWhileLoop
    {
        int[] arr = new int[5]; //5 - size of array

        public void StoreData() // Array stores data in index format and index starts with 0
        {
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            //arr[5] = 60; // This will throw an exception because the index is out of range

            int i = 0;
            do{
                Console.WriteLine(arr[i]);
                i++;
            }
            while (i<arr.Length) ;
        }
    }
}
