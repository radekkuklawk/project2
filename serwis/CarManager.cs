using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class CarManager
    {
        private CarData ReadCarData()

        {
            string Make;
            string Model;
          
            Console.WriteLine("Podaj dane samochodu:");
            Console.Write("Typ: ");
            Make = Console.ReadLine();
            Console.Write("Model: ");
            Model = Console.ReadLine();
           
            return new CarData(Make, Model);
        }
    }
}
