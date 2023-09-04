using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Utilities
{
    public class Super
    {
        public string Name => "super device";

        public ISensor Sensor;

        public int NumberOfSensor = 8;

        public Super()
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

        public void Send()
        {
            Console.WriteLine("send data to server ...");
            Console.WriteLine("--------------------------------------");
            //non capivo cosa si intendeva per inviare dati al server
        }
    }
}
