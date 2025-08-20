using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01
{
    //Task 1: Create Class
    public class Car
    {
        // Step 1: Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        // Step 2: Method
        public void Drive(int kilometers)
        {
            Mileage = Mileage + kilometers;
            Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km.");
            Console.WriteLine($"Total mileage: {Mileage} km.");
        }

        // Task 3: show info Method
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage} km.");
        }
    }
}
