using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNet
{
    public class StaticDisplay : IObserver<Weather>
    {
        private float _maxTemp = 0.0f;
        private float _minTemp = 200;
        private float _tempSum = 0.0f;
        private int _numReadings;

        private IDisposable _unsubscriber;
        private string _instName;
        public StaticDisplay(string name)
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
            _tempSum += value.Temperature;
            _numReadings++;

            

            if (value.Temperature > _maxTemp)
            {
                _maxTemp = value.Temperature;
            }

            if (value.Temperature < _minTemp)
            {
                _minTemp = value.Temperature;
            }

            Console.WriteLine("{4} "+ (_tempSum/_numReadings) + " / {0} / {1}",_maxTemp,_minTemp,_tempSum,_numReadings,this.Name);
        }
    }
}
