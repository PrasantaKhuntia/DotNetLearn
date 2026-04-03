using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearn
{
    internal interface IVehicle
    {
        public void Wheel();

        //public IVehicle() { };

        //int num;
    }

    internal class CarVehicle : IVehicle
    {
        public void Wheel()
        {
            Console.WriteLine("This is a 4 wheeler");
        }
    }

    internal class BikeVehicle : IVehicle
    {
        public void Wheel()
        {
            Console.WriteLine("This is a 2 wheeler");
        }
    }
}
