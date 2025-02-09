using System;

namespace SmartHouse
{
    public class SmartThermostat : SmartDevice
    {
        public int Temperature { get; private set; }

        public SmartThermostat(string name) : base(name)
        {
            Temperature = 22;
        }

        public void SetTemperature(int temperature)
        {
            if (temperature < 18 || temperature > 30)
            {
                Console.WriteLine("Temperature must be between 18 and 30°C.");
                return;
            }
            Temperature = temperature;
            Console.WriteLine($"{Name}'s temperature set to {Temperature}°C.");
        }

        public override void PerformFunction()
        {
            Console.WriteLine($"{Name} is maintaining the temperature at {Temperature}°C.");
        }
    }
}