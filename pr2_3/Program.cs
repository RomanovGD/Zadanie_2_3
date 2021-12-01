using System;

namespace pr2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100, p, t;
            Console.WriteLine("Задание III.\n");
            Console.WriteLine("while");
            while (n < 1000)
            {
                p = Convert.ToInt32(n / 100);
                t = n % 10;
                if (p==t)
                    Console.WriteLine($"\t{n}");
                n ++;
            }
            n = 100;
            Console.WriteLine();
            Console.WriteLine("do...while");
            do
            {
                p = Convert.ToInt32(n / 100);
                t = n % 10;
                if (p == t)
                    Console.WriteLine($"\t{n}");
                n ++;
            } while (n < 1000);
            Console.WriteLine();
            Console.WriteLine("for");
            for (n = 100; n < 1000; n ++)
            {
                p = Convert.ToInt32(n / 100);
                t = n % 10;
                if (p == t)
                    Console.WriteLine($"\t{n}");
            }

        }
    }
}
