using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utilities
{
    public class EntryDevice : IDevice
    {
        public string Name => "entry device";

        public ISensor Sensor;

        public int NumberOfSensor = 1;

        public EntryDevice()
        {
            Sensor = new Sensor();
            Sensor.TemperatureMeasure();
        }

        public void Print()
        {
            Console.WriteLine($"device type: {Name}\n");
            Console.WriteLine($"temperature sensor: {Sensor.Temperature}\n");
            Console.WriteLine("--------------------------------------");
        }
    }
}
