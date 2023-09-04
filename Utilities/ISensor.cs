using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public interface ISensor
    {
        double Temperature {  get; set; }
        double Humidity { get; set; }
        double Co2 {  get; set; }

        void TemperatureMeasure();
        void HumidityMeasure();
        void Co2Measure();
    }
}
