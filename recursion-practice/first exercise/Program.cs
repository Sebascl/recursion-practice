using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice.first_exercise
{
    class Program
    {
        //1. Write a program in C# to calculate the sum of numbers from 1 to n using recursion.

        static int CountSum(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            return n + CountSum(n - 1);
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("the total sum of number until n is " + CountSum(6));
        }
    }
}
