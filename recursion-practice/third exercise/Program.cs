using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice.third_exercise
{
    class Program
    {
        //3. Write a program in C to check a number is a prime number or not using recursion.
        static Boolean CheckPrime(int n, int i)
        {

            if (i * i > n)
            {
                return true;
            }
            if (n % i == 0)
            {
                return false;
            }
            if (n <= 2)
            {
                return (n == 2) ? true : false;
            }
            return CheckPrime(n, i + 1);
        }

        static void Main(string[] args)
        {
            int n = 13;
            if (CheckPrime(n, 2))
            {
                Console.WriteLine( n + " is prime ");
            }
            else
            {
                Console.WriteLine( n + " is not prime ");
            }
        }
    }
}

