
using System;
using System.Collections.Generic;

namespace SmartHouse
{
    public class SmartHouseManager
    {
        private SmartDevice[] devices;
        private int deviceCount;

        public SmartHouseManager(int maxDevices)
        {
            devices = new SmartDevice[maxDevices];
            deviceCount = 0;
        }

        public void AddDevice(SmartDevice device)
        {
            if (device == null)
            {
                Console.WriteLine("Cannot add a null device to the Smart House.");
                return;
            }

            if (deviceCount < devices.Length)
            {
                devices[deviceCount] = device;
                deviceCount++;
                Console.WriteLine($"Added {device.Name} to the Smart House.");
            }
            else
            {
                Console.WriteLine("Cannot add more devices. The Smart House is full.");
            }
        }

        public void ListDevices()
        {
            Console.WriteLine("Devices in the Smart House:");
            for (int i = 0; i < deviceCount; i++)
            {
                var device = devices[i];
                //provjera za null
                if (device == null)
                {
                    Console.WriteLine("- Null device found (skipped).");
                    continue;
                }

                Console.WriteLine($"- {device.Name} (Status: {(device.IsOn ? "ON" : "OFF")})");
            }
        }


        public void TurnAllOn()
        {
            for (int i = 0; i < deviceCount; i++)
            {
                devices[i]?.TurnOn();
            }
        }

        public void TurnAllOff()
        {
            for (int i = 0; i < deviceCount; i++)
            {
                devices[i]?.TurnOff();
            }
        }
    }
}