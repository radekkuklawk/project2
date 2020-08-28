using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    abstract class Car
    {
        public string make { get;}
        public string model { get;}
        public int km { get;}
        public double price { get;}
        
        public Car()
        {
            make = "";
            model = "";
            km = 0;
            price = 0.0;
        }

        public Car(string autoMake, string autoModel, int autoKM, double autoPrice)
        {
            this.make = autoMake;
            this.model = autoModel;
            this.km = autoKM;
            this.price = autoPrice;
        }

        public string GetInfo()
        {
            return $"Marka - {make}, Rok - {model}, Cena - {price}";
        }

        public abstract string TypeCar();

    }
}
