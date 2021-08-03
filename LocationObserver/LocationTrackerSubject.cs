using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationObserver
{
    public class LocationTrackerSubject : IObservable<Location>
    {
        private List<IObserver<Location>> _observers;
        public LocationTrackerSubject()
        {
            _observers = new List<IObserver<Location>>();
        }
        public IDisposable Subscribe(IObserver<Location> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void TrackLocation(Nullable<Location> loc)
        {
            foreach (var observer in _observers)
            {
                if (!loc.HasValue)
                    observer.OnError(new LocationUnknownException());
                else
                    observer.OnNext(loc.Value);
            }
        }

        public void EndTransmission()
        {
            foreach (var item in _observers.ToArray())
            {
                if (_observers.Contains(item))
                    item.OnCompleted();

                _observers.Clear();
            }
        }
    }
}
