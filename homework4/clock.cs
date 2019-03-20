using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace cmdTest
{
    delegate void timeDelegate();
    class clock
    {
        static void Main(string[] args)
        {
            timeDelegate td = new timeDelegate(up); 
            Console.WriteLine("请输入倒计时秒数，敲回车开始计时");
            int t = int.Parse(Console.ReadLine());
            setTime(td, t);
            Console.ReadKey();
        }
        public static void up()
        {
            Console.WriteLine("到点了，起床了");
        }
        public static void setTime(timeDelegate td, int t) 
        {
            for (int i = t; i >= 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            }
            td();
        }
    }
}