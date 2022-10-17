using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int v = n % 100 / 10;
            int x;

            if (1 <= n && n <= 999 && v != 0)
            {
                x = ((n % 100 / 10) * 10) + (n / 100) + ((n % 10) * 100);
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Неверное число");
            }
        }
    }
}