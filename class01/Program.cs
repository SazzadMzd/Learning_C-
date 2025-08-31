using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace class01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 42;
            int age = 30;

            double height = 5.9;

            int x = (int)5.9;

            string fullName = "John Doe";

            string number1 = "10";
            string number2 = "20";

            //Console.WriteLine(number1 + number2);

            bool isAlive = true;

            string[] names = new string[3];
            names[0] = "Alice";
            names[1] = "Bob";
            names[2] = "Charlie";

            //switch case example
            //take int input in array using loop

            //Task 01:
            //-------


            //Declare an integer array of size 5.Take input from the Console Window using loop.

            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Declare an integer array of size 3.Insert 3 random numbers.

            int[] numbersArray = {1, 5, 9};

            //Find the largest number using conditional statement (if-else)

            int largest = numbersArray[0];
            if(largest < numbersArray[1])
            {
                largest = numbersArray[1];
                if(largest < numbersArray[2])
                {
                    largest = numbersArray[2];
                }
            }
            

            Console.WriteLine("Largest Number in numbersArray: " + largest);

            //Find the smallest number using ‘Switch’ statement

            int smallest = numbersArray[0];
            switch (smallest > numbersArray[1])
            {
                case true:
                    smallest = numbersArray[1];
                    break;
                
                default:
                    break;
            }
            switch (smallest > numbersArray[2])
            {
                case true:
                    smallest = numbersArray[2];
                    break;
                
                default:
                    break;
            }

            Console.WriteLine("Smallest Number in numbersArray: " + smallest);


        }
    }
}
