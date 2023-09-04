using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Pro2 : IDevice
    {
        public string Name => "pro2 device";

        public ISensor Sensor;

        public int NumberOfSensor = 4;

        public Pro2()
        {
            Sensor = new Sensor();
        }

        public void Print()
        {
            Console.WriteLine($"device type: {Name}\n");
            for (int i = 1; i <= NumberOfSensor; i++)
            {
                Sensor.TemperatureMeasure();
                Sensor.HumidityMeasure();
                Sensor.Co2Measure();
                Console.WriteLine($"temperature sensor {i}: {Sensor.Temperature}");
                Console.WriteLine($"humidity sensor {i}: {Sensor.Humidity}");
                Console.WriteLine($"co2 sensor {i}: {Sensor.Co2}\n");
            }
            Console.WriteLine("--------------------------------------");
        }
    }
}
