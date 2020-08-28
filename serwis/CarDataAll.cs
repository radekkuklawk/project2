using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class CarDataAll
    {
        public string make { get; }
        public string model { get; }
        public int km { get; }
        public double price { get; }

        public CarData(string Make, string Model, string Km, string Price)
        {
            make = Make;
            model = Model;
            km = int.Parse(Km);
            price = double.Parse(Price);

        }
    }
}
