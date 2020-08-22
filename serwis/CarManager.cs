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
            string Km;
            string Price;
            
            Console.WriteLine("Podaj dane samochodu:");
            Console.Write("Typ: ");
            Make = Console.ReadLine();
            Console.Write("Model: ");
            Model = Console.ReadLine();
            Console.Write("Przebieg: ");
            Km = Console.ReadLine();
            Console.Write("Cena: ");
            Price = Console.ReadLine();

            return new CarData(Make, Model, Km, Price);
        }
    }
}
