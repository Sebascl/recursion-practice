using System;
using System.Collections.Generic;
using System.Text;

namespace recursion_practice.fourth_exercise
{
    class Program
    {
        //4. Spiderman
        static int SpiderWays(int building)
        {
            if (building <= 1 )
            {
                return building;
            }
            return (SpiderWays(building - 1) + SpiderWays(building - 2));
        }

        static int PossibleWays(int Ways)
        {
            return SpiderWays(Ways + 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("the possible ways that spiderman can jump are " + PossibleWays(3));
        }
    }
}
