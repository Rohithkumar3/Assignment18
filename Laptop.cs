using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        public string Brand { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }
        public Laptop(string brand)
        {
            Brand = brand;
        }

        public bool Connect()
        {
            if (!IsConnected)
            { 
                Console.WriteLine($"Connecting to {Brand} Laptop.");
                IsConnected = true;
                return true;
            }

            Console.WriteLine($"{Brand} Laptop is already connected.");
            return false;

        }

        public void Charge(int minutes)
        {
            if (IsConnected)
            {
                Console.WriteLine($"Charging {Brand} Laptop for {minutes} minutes");          
                BatteryLevel += minutes * 3 / 2;
            }
            else
            {
                Console.WriteLine($"{Brand} Laptop is not connected. Cannot charge.");
            }

        }

        public string Display()
        {
            var x = $"Laptop Brand: {Brand} \nBattery Level: {BatteryLevel}%";
            return x;
        }


    }
}
