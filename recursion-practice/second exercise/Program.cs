using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice.second_exercise
{
    class Program
    {
        //2. Write a program in C# to find the sum of digits of a number using recursion.
        static int DigitsSum(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return n % 10 + DigitsSum(n / 10);
        }
        static void Main2(string[] args)
        {
            Console.WriteLine("the sum of digits of a number is " + DigitsSum(75));
        }
    }

}
