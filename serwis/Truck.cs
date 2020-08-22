using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class Truck : Car
    {
        public string driveType { get;}
        
       public Truck() : base()
        {
            driveType = "";
        }

        public Truck(string truckMake, int truckModel, int truckKm, double truckPrice, string truckDriveType) : base(truckMake, truckModel, truckKm, truckPrice)
        { 
            this.driveType = truckDriveType; 
        }
        public override string TypeCar()
        {
            return "Truck";
        }
    }
}

