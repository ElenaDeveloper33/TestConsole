using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {

            Building house1 = new SkyScraper();
            Console.WriteLine(house1.GetFloors());
            //30

            House house2 = new SkyScraper();
            Console.WriteLine(house2.GetFloors());
            // 30

            House house3 = new OrdinaryHouse();
            Console.WriteLine(house3.GetFloors());
            // 1

            //OrdinaryHouse house4 = new House();
            //Console.WriteLine(house4.GetFloors());

            //int a = 5;
            //object o = a;
            //short s = (short)o;
            //Console.WriteLine(s);

        }
    }
}

