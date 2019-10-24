using System;

namespace Homework_assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int [100];
            int sumOfNumbers = 0;

            for (int i=0; i < 100; i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine(numbers[i]);  
            }
            for (int j =0; j <= 100; j++)
            {
                sumOfNumbers = sumOfNumbers + j;
            }
            
            Console.WriteLine($"Sum of numbers 1 to 100 is {sumOfNumbers}.");
       
        }

    }
}
