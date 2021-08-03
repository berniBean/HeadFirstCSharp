using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNet
{
    public class WeatherDataSubject : IObservable<Weather>
    {
        public List<IObserver<Weather>> _observers;
        public WeatherDataSubject()
        {
            _observers = new List<IObserver<Weather>>();
        }
        public IDisposable Subscribe(IObserver<Weather> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void TrackMeasurements(Nullable<Weather> weather)
        {
            foreach (var observer in _observers)
            {
                if (!weather.HasValue)
                    observer.OnError(new LocationUnknownException());
                else
                    observer.OnNext(weather.Value);
            }
        }

        public void EndTransmission()
        {
            foreach (var observer in _observers.ToArray())
            {
                if (_observers.Contains(observer))
                    observer.OnCompleted();
                _observers.Clear();
            }
        }
    }
}
