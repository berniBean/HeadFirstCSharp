using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNet
{
    public class ForecastDisplay : IObserver<Weather>
    {
        private IDisposable _unsubscriber;
        private string _instName;
        private float _currentPreasure = 29.92F;
        private float _lastPreasure;


        public ForecastDisplay(string name)
        {
            _instName = name;
        }
        public string Name
        { get { return this._instName; } }

        public virtual void Subscribe(IObservable<Weather> provider)
        {
            if (provider != null)
                _unsubscriber = provider.Subscribe(this);
        }
        public void OnCompleted()
        {
            Console.WriteLine("Transmision complete to : {0}", this.Name);
            
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: The data cannot be update.", this.Name);
        }

        public void OnNext(Weather value)
        {
            _lastPreasure = _currentPreasure;
            _currentPreasure = value.Pressure;

            
            if(_currentPreasure > _lastPreasure)
                Console.WriteLine("{0}: Improving weather on the way", this.Name);
            else if(_currentPreasure == _lastPreasure)
                Console.WriteLine("{0}: More of the same", this.Name);
            else if(_currentPreasure < _lastPreasure)
                Console.WriteLine("{0}: Watch out for cooler, rainy weather", this.Name) ;
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }

    }
}
