using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start, end, a = 0;
            Console.WriteLine("Starting Value:-");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("Ending Value:-");
            end = int.Parse(Console.ReadLine());

            for (int i = start; i < end; i++)
            {
                for (int j = 1; j < end; j++)
                {
                    if (i % j == 0)
                    {
                        a++;
                    }
                }

                if (a == 2)
                {
                    Console.WriteLine(i);
                }
                a = 0;
            }

            Console.ReadKey();
        }
    }
}