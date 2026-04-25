using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal class MultiThreading
    {
        public void Downloading() {

            Console.WriteLine("File downloading started");
            Thread.Sleep(5000); //Simulating the file downloading process
            Console.WriteLine("File downloading completed");
        }

        public void Processing() {

            Console.WriteLine("File processing started");
            Thread.Sleep(5000); //Simulating the file processing process
            Console.WriteLine("File processing completed");
        }

    }
}
