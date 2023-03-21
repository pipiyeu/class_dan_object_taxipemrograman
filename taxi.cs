using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membuattaxi
{
    public class taxi
    {
        public string drivername { get; set; }
        public Boolean onduty { get; set; }
        public int numpassenger { get; set; }

        public void taxiinfo()
        {
            Console.WriteLine("Driver name : {0}", drivername);

            if (onduty == true)
            {
                Console.WriteLine("On duty: Yes", onduty);
            } else if (onduty == false)
            {
                Console.WriteLine("On duty: No", onduty);
            }

            Console.WriteLine("Number Of Passenger: {0}", numpassenger);
        }

        public void pickuppassenger()
        { 

        if (onduty == true)
        {
            Console.WriteLine("\n{0} sedang menjemput penumpang", drivername);
        }else if (onduty == false)
            {
                Console.WriteLine("\n{0} sedang tidak menjemput penumpang", drivername);
            }
        }

        public void dropoffpassenger()
        {
            if (onduty == true)
            {
                Console.WriteLine("{0} sedang mengantar penumpang", drivername);
            } else if (onduty == false)
                {
                    Console.WriteLine("{0} sedang tidak mengantar penumpang", drivername);
                }
            
        }

    }
}