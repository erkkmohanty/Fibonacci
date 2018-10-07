using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( Fibonacci(9));
            Console.ReadLine();
        }

        static int Fibonacci(int num)
        {
            if (num <= 0)
                return 0;
            if (num == 1)
                return 1;
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
