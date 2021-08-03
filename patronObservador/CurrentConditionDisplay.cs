using patronObservador.Observador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronObservador
{
    public class CurrentConditionDisplay : IObserver, IDisplay  
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current conditions:" + _temperature +
                "F degrees and " + _humidity + "% humidity");
        }

        public void update(float temp, float humidity, float presure)
        {
            _temperature = temp;
            _humidity = humidity;
            display();
        }
    }
}
