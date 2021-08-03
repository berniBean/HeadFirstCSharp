using patronObservador.Observador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronObservador
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float _currentPreasure = 29.92F;
        private float _lastPreasure;
        private WeatherData _weatherData;
        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            Console.WriteLine("Forecast:");
            if(_currentPreasure > _lastPreasure)
                Console.WriteLine("Improving weather on the way");
            else if(_currentPreasure == _lastPreasure)
                Console.WriteLine("More of the same");
            else if (_currentPreasure < _lastPreasure)
                Console.WriteLine("Watch out for cooler, rainy weather");
        }

        public void update(float temp, float humidity, float presure)
        {
            _lastPreasure = _currentPreasure;
            _currentPreasure = presure;

            display();
        }
    }
}
