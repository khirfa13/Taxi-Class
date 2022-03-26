using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Taxi
    {
        //properties
        public string DriveName { get; set; }
        public string OnDuty { get; set; }
        public int NumPassenger { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Drive Name: {0}", DriveName);
            Console.WriteLine("On Duty: {0}", OnDuty);
            Console.WriteLine("Number of Passenger: {0}", NumPassenger);
        }
        
        public void PickUpPassenger()=>
            Console.WriteLine("{0} Sedang menjemput penumpang", DriveName);

        public void DropOffPassenger()=>
            Console.WriteLine("{0} Selesai mengantar penumpang", DriveName);
    }
}
