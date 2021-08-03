using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaGuitarras
{
    public class Guitar
    {
        public string _serialNumber { get; }
        public double _price { get; }
        public GuitarSpec _spec { get; }

        public Guitar(string serialNumber, double price,
                        Builder builder, string model, Tipe type,
                        Wood backWood, Wood topWood)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = new GuitarSpec(builder, model, type, backWood, topWood);
            
        }

        

    }
}
