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
            Smartphone phone = new Smartphone("One Plus Nord");
            phone.Connect();
            phone.Charge(20);
            Console.WriteLine(phone.Display());
            Laptop Laptop = new Laptop("HP");
            Laptop.Connect();
            Laptop.Charge(40);
            Console.WriteLine(Laptop.Display());
            Console.ReadKey();
        }
    }
    
    }

