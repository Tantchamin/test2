using System;

namespace quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0;
            double y = 0;
            x = double.Parse(Console.ReadLine());

            if (x == 1 || x == 2)
            {
                y = 2 * x;
            }
            else if (x >= 5 && x <= 8) 
            {
                y = (3 * x) + 2;
            }
            else if (x == 3)
            {
                y = Math.Sqrt(x);
            }
            else if (x>=9 && x <= 12)
            {
                y = Math.Sqrt(x);
            }
            else if (x == 4)
            {
                y = Math.Pow(x, 2) - 5;
            }
            else
            {
                y = x;
            }

            Console.WriteLine("Y = {0}", y);
        }
    }
}
