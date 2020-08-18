using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class Sedan : Car
    {
        public int Doors { get;}

       public Sedan() : base()
        {
            Doors = 0;
        }

        public Sedan(string carMake, int carModel, int carMileage, double carPrice, int carDoors) : base (carMake, carModel, carMileage, carPrice)
        {
            this.Doors = carDoors;
        }

    }
}
