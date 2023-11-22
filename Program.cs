using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main()
        {
            Smartphone smartphone = new Smartphone();
            Laptop laptop = new Laptop();

            //Properties for Smartphone
            smartphone.Connect();
            smartphone.Charge(60);
            smartphone.Display();

            // Properties for Laptop
            laptop.Connect();
            laptop.Charge(120);
            laptop.Display();

            Console.WriteLine("\nSmartphone Information: ");           
            smartphone.Display();

            Console.WriteLine("\nLaptop Information: ");
            laptop.Display();
            Console.ReadKey();
        }
    }

    
    }

