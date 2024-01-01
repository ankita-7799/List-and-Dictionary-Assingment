using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Dictionary_Assingment.Properties
{
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double Price { get; set; }
        }

    class CarDealership
    {
        static void Main()
        {
            List<Car> inventory = new List<Car>();

            
            inventory.Add(new Car { Make = "Toyota", Model = "Camry", Year = 2022, Price = 25000 });
            inventory.Add(new Car { Make = "Honda", Model = "Accord", Year = 2023, Price = 27000 });
            inventory.Add(new Car { Make = "Ford", Model = "Mustang", Year = 2021, Price = 35000 });

            
            Console.WriteLine("Cars in the inventory:");
            foreach (Car car in inventory)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model} - ${car.Price}");

            }

            Console.ReadLine();
        
}   }   }
