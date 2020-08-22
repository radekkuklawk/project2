using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class CarData
    {
        public string make { get; }
        public int model { get; }
        public int km { get; }
        public double price { get; }

        public CarData(string Make, string Model, string Km, string Price)
        {
            make = Make;
            model =int.Parse(Model);
            km = int.Parse(Km);
            price = double.Parse(Price);

        }
    }
}
