using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public  class BarMan
    {
        public async Task CalientaSnack()
        {
            Console.WriteLine("Mete el snack al horno");
            Thread.Sleep(10000);
            Console.WriteLine("Mete el snack al horno");

        }

        public async Task HacerCoctel()
        {
            Console.WriteLine("comienza a hacer el coctel");
            Thread.Sleep(10000);
            Console.WriteLine("sirve el coctel");
        }
    }
}
