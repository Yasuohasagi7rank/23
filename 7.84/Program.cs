using System;

namespace _7._84
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();

            Console.Write("Рандомные числа: ");

            double a;
            double b = 0;
            for (int i = 1; i <= 10; i++)
            {
                a = rdm.NextDouble() * 20;
                b += a;
                Console.Write($"{a:f2} ");
            }
            Console.WriteLine(b > 100.78 ? "\nСумма чисел превышает 100,78" : "\nСумма чисел НЕ превышает 100,78");
            Console.ReadKey();
            Console.Clear();
        }
    }
    
}
