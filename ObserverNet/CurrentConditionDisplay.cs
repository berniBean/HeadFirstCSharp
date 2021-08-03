using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverNet
{
    public class CurrentConditionDisplay : IObserver<Weather>
    {
        private IDisposable _unsubscriber;
        private string _instName;

        public CurrentConditionDisplay(string name)
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
            Console.WriteLine("Transmision complete to : {0}" , this.Name);
            
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("{0}: The data cannot be update.", this.Name);
        }

        public void OnNext(Weather value)
        {
            Console.WriteLine("{2}:  {0} F degrees and {1}  % humidity", value.Temperature, value.Humidity, this.Name);
        }

        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
