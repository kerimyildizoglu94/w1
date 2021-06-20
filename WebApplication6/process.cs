using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class process
    {
        public static int Factorial(int x)
        {
            if (x <= 0)
            { return 1; }
            else
            {
                return x * Factorial(x - 1);
            }
        }
        public static int Fibonacci(int x)
        {
            if (x <= 1)
            { return x; }
            else
            {
                return Fibonacci(x - 2) + Fibonacci(x - 1);
            }
        }
        public static int Ackermann(int x, int y)
        {
            if (x == 0)
            { return y + 1; }
            else if (y == 0) { return Ackermann(x - 1, 1); }
            else
            {
                return Ackermann(x - 1, Ackermann(x, y - 1));
            }
        }

    }
}