using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengetesan nilai prop
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
         
            Console.ReadKey();
        }

    }
}
