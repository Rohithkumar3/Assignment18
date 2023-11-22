using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
        public class Smartphone : IConnectable, IRechargeable, IDisplayable
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
        }
    }
