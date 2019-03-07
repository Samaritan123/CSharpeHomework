using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组的元素个数");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入" + n + "个数字，每行一个");
            int[] a = new int[100];
            int max = a[1], min = a[1], sum = a[1];
            double avg = a[1];
            for (int i = 1; i <= n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
                sum += a[i];
                avg += a[i];
            }
            avg /= n;
            Console.WriteLine("数组的最大值为" + max);
            Console.WriteLine("数组的最小值为" + min);
            Console.WriteLine("数组的和为" + sum);
            Console.WriteLine("数组的平均值为" + avg);
        }
    }
}
