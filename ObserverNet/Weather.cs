using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNet
{
    public struct Weather 
    {
        private float _temperature, _humidity, _pressure;

        public Weather(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;
        }

        public float Temperature
        { get { return _temperature; } }
        public float Humidity
        { get { return _humidity; } }
        public float Pressure
        { get { return _pressure; } }

    }
}
