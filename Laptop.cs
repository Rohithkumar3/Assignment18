using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    /*  public class Laptop : IConnectable, IRechargeable, IDisplayable
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
      }*/

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
                Console.WriteLine($"Connecting to {Brand} Laptop...");
                // Simulate connection process
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
                Console.WriteLine($"Charging {Brand} Laptop for {minutes} minutes...");
                // Simulate charging process
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
