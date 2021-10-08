using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] Fibonacci_numbers = new long[91];
            Fibonacci_numbers[0] = 1; Fibonacci_numbers[1] = 1;
            for (int i = 2; i < 91; i++)
            {
                Fibonacci_numbers[i] = Fibonacci_numbers[i - 2] + Fibonacci_numbers[i - 1];
            }
            for (int i = 0; i < 91; i++)
            {
                Console.WriteLine($"The {i + 1}. fibonacci-number: {Fibonacci_numbers[i]}");
            }
            Console.ReadLine();
        }
        /*static int fibonacci(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }*/
    }
}
