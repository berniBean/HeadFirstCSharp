using System;
using System.Collections.Generic;

namespace LocationObserver
{
    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<Location>> _observers;
        private IObserver<Location> _observer;

        public Unsubscriber(List<IObserver<Location>> observers, IObserver<Location> observer)
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