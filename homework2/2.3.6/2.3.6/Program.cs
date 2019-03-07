using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a Number:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i * i <= n; i ++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0) n = n / i;
                    Console.WriteLine(i);
                }
            }
            if (n > 1) Console.WriteLine(n);
        }
    }
}
