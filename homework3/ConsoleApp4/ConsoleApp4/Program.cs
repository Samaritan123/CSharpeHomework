using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class SingletonMode
    {
        public static SingletonMode instance { get; private set; } = null;
        private SingletonMode()
        {
            Console.WriteLine("构造函数");
        }

        static SingletonMode()///Clr运行的时候，进行初始化，并且只执行一次
        {
            instance = new SingletonMode();
        }

        public void Print()
        {
            Console.WriteLine("Hello World！！");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            SingletonMode.instance.Print();
        }
    }
}
