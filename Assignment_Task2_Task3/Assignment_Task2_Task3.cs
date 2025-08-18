namespace Assignment_Task2_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 02:

            //Declare an integer array of size 5.Take input from the Console Window using loop.

            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter number " + (i + 1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("numbers = ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] +", ");
            }
            Console.WriteLine(" ");

            //Task 03

            //Declare an integer array of size 3.Insert 3 random numbers.

            int[] numArray = new int[3];
            Random random = new Random();
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = random.Next(1, 100);
            }

            Console.Write("numArray = ");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write(numArray[i] + ", ");
            }
            Console.WriteLine(" ");

            //Find the largest number using conditional statement (if-else)

            int largest = numArray[0];
            if (largest < numArray[1])
            {
                largest = numArray[1];
                if (largest < numArray[2])
                {
                    largest = numArray[2];
                }
            }


            Console.WriteLine("Largest Number in Array: " + largest);

            //Find the smallest number using ‘Switch’ statement

            int smallest = numArray[0];
            switch (smallest > numArray[1])
            {   
                case true:
                    smallest = numArray[1];
                    break;

                default:
                    break;
            }
            switch (smallest > numArray[2])
            {
                case true:
                    smallest = numArray[2];
                    break;

                default:
                    break;
            }

            Console.WriteLine("Smallest Number in Array: " + smallest);
        }
    }
}
