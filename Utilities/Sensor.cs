using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Sensor : ISensor
    {
        public double Temperature { get; set;}
        public double Humidity { get; set; }
        public double Co2 { get; set; }

        public void TemperatureMeasure()
        {
            Random rnd = new Random();
            double value = rnd.Next(1, 40);
            Temperature = value;
        }

        public void HumidityMeasure()
        {
            Random rnd = new Random();
            double value = rnd.Next(50, 60);
            Humidity = value;
        }

        public void Co2Measure()
        {
            Random rnd = new Random();
            double value = rnd.Next(250, 400);
            Co2 = value;
        }
    }
}
