using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationObserver
{
    public struct Location
    {
        double _lat, _lon;

        public Location(double latitude, double longitude)
        {
            _lat = latitude;
            _lon = longitude;
        }

        public double Latitude
        { get { return _lat; } }

        public double Longitude
        { get { return _lon; } }
    }
}
