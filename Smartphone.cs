using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    /*    public class Smartphone : IConnectable, IRechargeable, IDisplayable
        {
             bool IsConnected;
             int batteryLevel;
             string displayInfo;

            public Smartphone()
            {
                IsConnected = false;
                batteryLevel = 0;
                displayInfo = "Smartphone Screen";
            }

            public bool Connect()
            {
                if (!IsConnected)
                {
                    Console.WriteLine("Smartphone connected.");
                    IsConnected = true;
                }
                else
                {
                    Console.WriteLine("Smartphone is already connected.");
                }
                return IsConnected;
            }

            public void Charge(int minutes)
            {
                Console.WriteLine($"Charging Smartphone for {minutes} minutes.");
                batteryLevel += minutes / 10;
                if (batteryLevel > 100)
                {
                    batteryLevel = 100;
                }
            }

            public string Display()
            {
                Console.WriteLine($"Displaying information on Smartphone: {displayInfo}");
                return displayInfo;
            }
        }*/

    internal class Smartphone : IConnectable, IRechargeable, IDisplayable

    {
        public string Model { get; set; }
        public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }

        public Smartphone(string model)
        {
            Model = model;
        }

        public bool Connect()
        {
            if (!IsConnected)
            {
                Console.WriteLine($"Connecting to {Model}...");
                IsConnected = true;
                return true;
            }

            Console.WriteLine($"{Model} is already connected.");
            return false;

        }

        public void Charge(int minutes)
        {
            if (IsConnected)
            {
                Console.WriteLine($"Charging {Model} for {minutes} minutes...");
                BatteryLevel += minutes * 7 / 2;
            }
            else
            {
                Console.WriteLine($"{Model} is not connected. Cannot charge.");
            }

        }

        public string Display()
        {
            var x = $"Smartphone Model: {Model} \nBattery Level: {BatteryLevel}%";


            return x;
        }


    }
}
