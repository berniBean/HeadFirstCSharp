using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaGuitarras
{
    public class Inventario
    {
        private List<Guitar> _guitars;
        public Inventario()
        {
            _guitars = new List<Guitar>();
        }

        public void addGuitar(string serialNumber, double price,
                                Builder builder, string model,
                                 Tipe type, Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,model ,type, backWood, topWood);
            _guitars.Add(guitar);
        }


        public Guitar getGuitar(string serialNumber)
        {
            foreach (var item in _guitars)
            {
                if (item._serialNumber.Equals(serialNumber))
                    return item;
            }
            return null;
        }

        public List<GuitarSpec> search(GuitarSpec searchSpec)
        {
            List<GuitarSpec> matchingGuitars = new List<GuitarSpec>();
            foreach (var item in _guitars)
            {
                GuitarSpec guitarSpec = item._spec;
                if (searchSpec._builder != guitarSpec._builder)
                    continue;
                string model = searchSpec._model.ToLower();
                if ((model != null) && (!model.Equals("")) &&
                    (!model.Equals(guitarSpec._model.ToLower())))
                    continue;
                if (searchSpec._type != guitarSpec._type)
                    continue;
                if (searchSpec._backWood != guitarSpec._backWood)
                    continue;
                if (searchSpec._topWood != guitarSpec._topWood)
                    continue;
                matchingGuitars.Add(guitarSpec);
                        
            }

            return matchingGuitars;
        }
    }
}
