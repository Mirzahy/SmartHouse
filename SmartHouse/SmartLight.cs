
using System;

namespace SmartHouse
{
    public class SmartLight : SmartDevice
    {
        public int Brightness {
            get;
            private set; 
        }

        public SmartLight(string name) : base(name)
        {
            Brightness = 50;
        }

        public void SetBrightness(int brightness)
        {
            if (brightness < 0 || brightness > 100)
            {
                Console.WriteLine("Brightness must be between 0 and 100.");
                return;
            }
            Brightness = brightness;
            Console.WriteLine($"{Name}'s brightness set to {Brightness}%.");
        }

        public override void PerformFunction()
        {
            Console.WriteLine($"{Name} is lighting up the room at {Brightness}% brightness.");
        }
    }
}