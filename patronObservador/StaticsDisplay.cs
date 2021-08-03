using patronObservador.Observador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronObservador
{
    public class StaticsDisplay : IObserver, IDisplayElement
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;
        private WeatherData _weatherData;
        public StaticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Avg/Max/Min temperature = " +(_tempSum/ _numReadings) + "/" + _maxTemp + "/" + _minTemp);
        }


        public void update(float temp, float humidity, float presure)
        {
                _tempSum += temp;
                _numReadings++;

                if (temp > _maxTemp)
                {
                    _maxTemp = temp;
                }

                if (temp < _minTemp)
                {
                    _minTemp = temp;
                }

                display();
            
        }
    }
}
