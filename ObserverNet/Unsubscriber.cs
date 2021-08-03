using System;
using System.Collections.Generic;

namespace ObserverNet
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<Weather>> _observers;
        private IObserver<Weather> _observer;

        public Unsubscriber(List<IObserver<Weather>> observers, IObserver<Weather> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}