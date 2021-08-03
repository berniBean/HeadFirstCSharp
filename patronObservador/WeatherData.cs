using patronObservador.Observador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronObservador
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        public void notifyObserver()
        {
            foreach (var item in _observers)
            {
                item.update(_temperature, _humidity, _pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            
            _observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float preasure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = preasure;
            measurementsChanged();
        }
    }
}
