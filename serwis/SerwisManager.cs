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

        public Sedan CreateSedan(string carMake, string carModel, int carKm, double carPrice, int carDoors)
        {
            Sedan car = new Sedan(carMake, carModel, carKm, carPrice, carDoors);
            _Cars.Add(car);
            return car;
        }

        public Suv CreateSuv(string SUVMake, string SUVModel, int SUVKM, double SUVPrice, int SUVPassengers)
        {
            Suv car = new Suv(SUVMake, SUVModel, SUVKM, SUVPrice, SUVPassengers);
            _Cars.Add(car);
            return car;
        }

        public Truck CreateTruck(string truckMake, string truckModel, int truckKm, double truckPrice, string truckDriveType)
        {
            Truck car = new Truck(truckMake, truckModel, truckKm, truckPrice, truckDriveType);
            _Cars.Add(car);
            return car;
        }
        public IEnumerable <Car> GetAllCars()
        {
            return _Cars;
        }

        public IEnumerable<Car> GetAllTypeCar(string Make, string Model)
        {
            return _Cars.Where(x => x.make == Make && x.model == Model);
        }
    }
}
