
using System;

namespace SmartHouse
{
    public abstract class SmartDevice
    {
        public string Name { 
            get; 
            set; 
        }
        public bool IsOn { 
            get;
            private set;
        }

        public  SmartDevice(string name)
        {
            Name = name;
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} is now ON.");
        }

        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} is now OFF.");
        }

        public abstract void PerformFunction();
    }
}