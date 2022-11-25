using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskPokerStars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(); 
 
            for (int i = 0; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            Console.WriteLine(numbers.Where(x=>x%2==0).Count());
            Console.WriteLine(numbers.Where(x=>x%2==1).Count());
            Console.WriteLine(numbers.Where(x=>x==0).Count());
            


        }
    }
}
