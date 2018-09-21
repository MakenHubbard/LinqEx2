using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> GroupOfNumbers = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };

            var fourSixMultiples = GroupOfNumbers.Where(x => x % 4 == 0 || x % 6 == 0);

            List<int> CorrectNums = fourSixMultiples.ToList();

            foreach (int num in CorrectNums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
            Console.WriteLine("Oh wait your gay!!! haha");
            Console.ReadLine();

        }
    }
}
