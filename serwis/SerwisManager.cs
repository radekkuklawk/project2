using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class SerwisManager
    {
        private IList<Car> _Cars;

        public SerwisManager()
        {
            _Cars = new List<Car>();
        }

        public Sedan CreateSedan(string carMake, int carModel, int carKm, double carPrice, int carDoors)
        {
            Sedan car = new Sedan(carMake, carModel, carKm, carPrice, carDoors);
            _Cars.Add(car);
            return car;
        }

        public Suv CreateSuv(string SUVMake, int SUVModel, int SUVKM, double SUVPrice, int SUVPassengers)
        {
            Suv car = new Suv(SUVMake, SUVModel, SUVKM, SUVPrice, SUVPassengers);
            _Cars.Add(car);
            return car;
        }

        public Truck CreateTruck(string truckMake, int truckModel, int truckKm, double truckPrice, string truckDriveType)
        {
            Truck car = new Truck(truckMake, truckModel, truckKm, truckPrice, truckDriveType);
            _Cars.Add(car);
            return car;
        }
    }
}
