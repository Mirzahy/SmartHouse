using System;

namespace SmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
           //max broj uredjaja je 10
            SmartHouseManager houseManager = new SmartHouseManager(10);

            SmartLight livingRoomLight = new SmartLight("Living Room Light");
            SmartThermostat thermostat = new SmartThermostat("Thermostat");

            houseManager.AddDevice(livingRoomLight);
            houseManager.AddDevice(thermostat);

            houseManager.ListDevices();

            livingRoomLight.TurnOn();
            livingRoomLight.SetBrightness(75);
            livingRoomLight.PerformFunction();
            livingRoomLight.SetBrightness(-25);
            livingRoomLight.PerformFunction();
            livingRoomLight.SetBrightness(150);

            thermostat.TurnOn();
            thermostat.TurnOff();
            thermostat.TurnOn();

            thermostat.SetTemperature(24);
            thermostat.SetTemperature(34);
            thermostat.SetTemperature(17);
            thermostat.PerformFunction();

            houseManager.TurnAllOff();

            houseManager.TurnAllOn();

          
        }
    }
}
