namespace Module01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Task 2: Create Object
                Car myCar1 = new Car();
                Car myCar2 = new Car();

                // Step 1: Set Props
                myCar1.Brand = "Toyota";
                myCar1.Model = "Corolla";
                myCar1.Year = 2020; 
                myCar1.Mileage = 15000;

                myCar2.Brand = "Tesla";
                myCar2.Model = "3X";
                myCar2.Year = 2024; 
                myCar2.Mileage = 10000;


                // Step 2: Call Method
                myCar1.Drive(300);
                myCar2.Drive(500);

                myCar2.ShowCarInfo();

            }

        }
    }
}
