using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int []v = new int[101];
            for (int i = 1; i <= 100; i ++) v[i] = 0;
            for (int i = 2; i <= 100; i ++)
                for (int j = i + i; j <= 100; j += i)
                    v[j] = 1;
            for (int i = 2; i <= 100; i ++)
            {
                if (v[i] == 0) Console.WriteLine(i);
            }
        }
    }
}
