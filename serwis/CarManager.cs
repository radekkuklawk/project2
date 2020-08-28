using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serwis
{
    class CarManager
    {
        private SerwisManager _serwisManager;
        public BankManager()
        {
            _serwisManager = new SerwisManager();
        }

        public void Run()
        {
            int action;
            do
            {
                PrintMainMenu();
                action = SelectedAction();

                switch (action)
                {
                    case 1:
                        Console.Clear();
                        ListOfAllCars();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        AddBillingAccount();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        AddSavingsAccount();
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        AddMoney();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        ListOfCarsModel();
                        Console.ReadKey();
                        break;
                   default:
                        Console.Write("Wybierz inne polecenie");
                        break;
                }
            }
            while (action != 0);

        }

        private void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz akcję:");
            Console.WriteLine("1 - Lista samochodów ");
            Console.WriteLine("2 - Dodaj samochod typu sedan");
            Console.WriteLine("3 - Dodaj samochód typu suv");
            Console.WriteLine("4 - Dodaj samochód typu truck");
            Console.WriteLine("5 - Lista samochodów danego modelu");
            Console.WriteLine("0 - Zakończ");
        }
        private int SelectedAction()
        {
            Console.Write("Akcja: ");
            string action = Console.ReadLine();
            if (string.IsNullOrEmpty(action))
            {
                return -1;
            }
            return int.Parse(action);
        }
        private void ListOfCarsModel()
        {
            Console.Clear();
            CarData data = ReadCarData();
            Console.WriteLine();
            Console.WriteLine($"Lista {data.make} {data.model}");
            foreach(Car cars in _serwisManager.GetAllCars)
            {
                Console.WriteLine($"{cars.make}");
                Console.WriteLine($"{cars.model}");
                Console.WriteLine($"{cars.km}");
                Console.WriteLine($"{cars.price}");
            }

        }
        private void ListOfAllCars()
        {
            Console.Clear();
            Console.WriteLine("Wszystkie samochody:");
            foreach (Car cars in _serwisManager.GetAllCars())
            {
                Console.WriteLine($"{cars.make}");
                Console.WriteLine($"{cars.model}");
                Console.WriteLine($"{cars.km}");
                Console.WriteLine($"{cars.price}");
            }
            Console.ReadKey();
        }

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
