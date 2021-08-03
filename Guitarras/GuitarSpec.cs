using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaGuitarras
{
    public class GuitarSpec 
    {
        public Builder _builder { get; }
        public string _model { get; }
        public Tipe _type { get; }
        public Wood _backWood { get; }
        public Wood _topWood { get; }

        public GuitarSpec(Builder builder, string model, Tipe type, Wood backWood, Wood topWood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backWood = backWood;
            _topWood = topWood;
        }


    }
}
