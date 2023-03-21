using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membuattaxi
{
    public class Program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.drivername = "Andrea";
            taxi.onduty = false;
            taxi.numpassenger = 10;

            taxi.taxiinfo();
            taxi.pickuppassenger();
            taxi.dropoffpassenger();
           
            Console.ReadKey();
        }
    }
}
