using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNet
{
    public class HeatIndexDisplay : IObserver<Weather>
    {
        private float _heatIndex = 0.0f;
        private IDisposable _unsubscriber;
        private string _instName;
        public HeatIndexDisplay(string name)
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
            float t = value.Temperature;
            float rh = value.Humidity;

            _heatIndex = (float)
                (
                (16.923 + (0.185212 * t)) +
                (5.37941 * rh) -
                (0.100254 * t * rh) +
                (0.00941695 * (t * t)) +
                (0.00728898 * (rh * rh)) +
                (0.000345372 * (t * t * rh)) -
                (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) -
                (0.000038646 * (t * t * t)) +
                (0.0000291583 * (rh * rh * rh)) +
                (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) -
                (0.0000000218429 * (t * t * t * rh * rh)) +
                (0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            Console.WriteLine("{1}: {0}",_heatIndex,Name);
        }
        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}

