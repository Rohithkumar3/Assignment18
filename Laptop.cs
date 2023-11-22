using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    public class Laptop : IConnectable, IRechargeable, IDisplayable
    {
         bool IsConnected;
        int batteryLevel;
        string displayInfo;

        public Laptop()
        {
            IsConnected = false;
            batteryLevel = 0;
            displayInfo = "Laptop Screen";
        }

        public bool Connect()
        {
            if (!IsConnected)
            {
                Console.WriteLine("Laptop connected.");
                IsConnected = true;
            }
            else
            {
                Console.WriteLine("Laptop is already connected.");
            }
            return IsConnected;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"Charging Laptop for {minutes} minutes.");
            batteryLevel += minutes / 5;
            if (batteryLevel > 100)
            {
                batteryLevel = 100;
            }
        }

        public string Display()
        {
            Console.WriteLine($"Displaying information on Laptop: {displayInfo}");
            return displayInfo;
        }
    }
}
