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
                sumOfNumbers = sumOfNumbers + i;
               
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine($"Sum of numbers 1 to 100 is {sumOfNumbers}.");
       
        }

    }
}
